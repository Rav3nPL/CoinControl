using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;


namespace CoinControl
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            dgvOut.Rows.Add("1Rav3nkMayCijuhzcYemMiPYsvcaiwHni", "0.01");
            log("Fill IP:port, rpcuser and rpcpassword, press button.");
            log("Small suggestion in outputs... :D");
        }
        public string ip;
        public string rpcuser;
        public string rpcpassword;
        public string hextx = "";
        public string signtx = "";

        public string SendCommand(string strCommand, string strParameters = "") //from namecoinGUI
        {
            byte[] byteResponse = new byte[0];
            string strResponse = string.Empty;

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(ip);

            webRequest.Credentials = new NetworkCredential(rpcuser, rpcpassword);
            webRequest.ContentType = "application/json-rpc";
            webRequest.Method = "POST";

            string s = "{\"jsonrpc\": \"1.0\", \"id\":\"Rav3nCoinControl\", \"method\": \"" + strCommand + "\", \"params\":[" + strParameters + "]}";
            byte[] byteArray = Encoding.UTF8.GetBytes(s);
            log(s);
            webRequest.ContentLength = byteArray.Length;
            try
            {
                Stream dataStream = webRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse webResponse = webRequest.GetResponse();

                if (webResponse.ContentLength > 0)
                {
                    StreamReader ResponseStream = new StreamReader(webResponse.GetResponseStream());
                    strResponse = ResponseStream.ReadToEnd();
                    ResponseStream.Close();
                }
                webResponse.Close();
            }
            catch (System.Net.WebException e)
            {
                    string strLog = DateTime.Now.ToString() + ": " + e.Message + Environment.NewLine;
                    log(strLog);
                    MessageBox.Show(strLog, "Communication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (strResponse != "") { log(strResponse); }
            }

            if (strResponse != string.Empty)
            {
                log(strResponse);
            }
            return strResponse;
        }


        private void btGet_Click(object sender, EventArgs e)
        {
            tbLog.Text = "";
            string resp = SendCommand("listunspent");
            log("Loading inputs, it might take a while...");
            btGet.Enabled = false;
            Application.DoEvents();
            if (resp != "")
            {
                dynamic d = JsonConvert.DeserializeObject(resp);
                dgvIn.Rows.Clear();
                foreach (dynamic i in d.result)
                {
                    dgvIn.Rows.Add(false, i.amount, i.confirmations, i.txid, i.vout);
                }
                log("Data loaded. Sort inputs and choose!");
            }
            else
            {
                log("Oops!");
            }
            btGet.Enabled = true;
        }
        
            
        void log(string s)
        {
            tbLog.Text = s + Environment.NewLine + tbLog.Text;
        }
        private void btConnect_Click(object sender, EventArgs e)
        {
            ip = "http://" + tbIp.Text;
            rpcuser = tbUser.Text;
            rpcpassword = tbPass.Text;
            string resp = "";
            try
            {
                resp = SendCommand("getinfo");
            }
            catch (Exception ex)
            {
                log("Connection error!");
                log(ex.Message.ToString());
            }
            finally
            {
                if (resp != "")
                {
                    log(resp);
                    log("Connected, now get inputs.");
                    panel1.Visible = false;
                }
            }
        }
    
        private void btPrepare_Click(object sender, EventArgs e)
        {
            //przygotuj nie podpisaną tx do sprawdzenia: createrawtransaction [{"txid":txid,"vout":n},...] {address:amount,...}
            if (dgvOut.Rows[0].Cells[0].Value != null)
            {
                btPrepare.Enabled = false;
                log("Gathering data...");
                Application.DoEvents();

                string i = " [";
                //zbieramy inputy
                foreach (DataGridViewRow d in dgvIn.Rows)
                {
                    if (Convert.ToBoolean(d.Cells[0].Value) == true)
                    {
                        string tx = d.Cells[3].Value.ToString();
                        string vout = d.Cells[4].Value.ToString();
                        i += "{\"txid\":\"" + tx + "\",\"vout\":" + vout + "},";
                    }
                }
                i = i.Remove(i.Length - 1); //kill last ","
                i += "], {";

                //zbieramy outputy
                foreach (DataGridViewRow d in dgvOut.Rows)
                {
                    if (d.Cells[0].Value != null)
                    {
                        string addr = d.Cells[0].Value.ToString();
                        double am = Convert.ToDouble(d.Cells[1].Value.ToString());
                        string amou = String.Format(CultureInfo.InvariantCulture, "{0:0.00000000}", am);
                        i += "\""+addr +"\":" + amou + ",";
                    }
                }
                i = i.Remove(i.Length - 1); //kill last ","
                i += "} ";
                log("tx:");
                log(i);
                log("Creating transaction on daemon, please be patient...");
                Application.DoEvents();
                string resp = SendCommand("createrawtransaction", i);
                if (resp != "")
                {
                    dynamic dy = JsonConvert.DeserializeObject(resp);
                    hextx = dy.result;
                    log(resp);
                    log("Transaction created, now sign it!");
                }
                else
                {
                    log("Error! Check addresses, amounts. Maybe bigger fee need?");
                }
                btPrepare.Enabled = true;
            }
            else
            {
                log("No output address data!");
            }
        }
        

        private void btSign_Click(object sender, EventArgs e)
        {
            //wyślij do podpisu: signrawtransaction <hexstring> [{"txid":txid,"vout":n,"scriptPubKey":hex},...] [<privatekey1>,...]
            log("Sending TX to sign by daemon...");
            btSign.Enabled = false;
            Application.DoEvents();
            string resp = SendCommand("signrawtransaction", "\"" + hextx + "\"");
            if (resp != "")
            {
                dynamic dy = JsonConvert.DeserializeObject(resp);
                signtx = dy.result.hex;
                log("Transaction signed, now send it!");
            }
            else
            {
                log("Oops! Try again?");
            }
            btSign.Enabled = true;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            //wyślij podpisaną sendrawtransaction <hexstring>
            log("Sending TX to network...");
            btSend.Enabled = false;
            Application.DoEvents();
            string resp = SendCommand("sendrawtransaction", "\"" + signtx + "\"");
            if (resp != "")
            {
                dynamic dy = JsonConvert.DeserializeObject(resp);
                string txid = dy.result;
                log("Transaction sent, TXID: " + txid);
                log("Clearing input list.");
                dgvIn.Rows.Clear();
            }
            else
            {
                log("Oops! Try again?");
            }
            btSend.Enabled = true;
        }

        private void dgvIn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //obsługa klika na checkbox
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                double amount = 0;
                foreach (DataGridViewRow d in dgvIn.Rows)
                {
                    if (Convert.ToBoolean(d.Cells[0].Value)==true)
                    {
                        amount += Convert.ToDouble(d.Cells[1].Value);
                    }
                }
                tbSent.Text = amount.ToString();
                dgvOut.Rows[0].Cells[1].Value = amount;
            }
        }


        private void dgvIn_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //po kliku odpal koniec edycji
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                dgvIn.EndEdit();
            }
        }

        private void dgvOut_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //zmiana danych
            double amount = 0;
            foreach (DataGridViewRow d in dgvOut.Rows)
            {
                if (d.Cells[1].Value != null)
                {
                    double add = 0;
                    string s = d.Cells[1].Value.ToString();
                    Double.TryParse(s, out add);
                    if (add > 0) { amount += add; }
                    else { log("Incorrect value in output?"); }
                }
            }
            tbOut.Text = amount.ToString();
            tbFee.Text = String.Format(CultureInfo.InvariantCulture, "{0:0.00000000}", (Convert.ToDouble(tbSent.Text) - Convert.ToDouble(tbOut.Text)).ToString());
        }
    }
}
