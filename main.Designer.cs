namespace CoinControl
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGet = new System.Windows.Forms.Button();
            this.btSign = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.dgvIn = new System.Windows.Forms.DataGridView();
            this.take = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addresss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSent = new System.Windows.Forms.TextBox();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOut = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btPrepare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.nudSelect = new System.Windows.Forms.NumericUpDown();
            this.btSelect = new System.Windows.Forms.Button();
            this.bdDeselect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btSelectAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(12, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 0;
            this.btGet.Text = "Get inputs";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // btSign
            // 
            this.btSign.Location = new System.Drawing.Point(411, 374);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(75, 23);
            this.btSign.TabIndex = 1;
            this.btSign.Text = "Sign TX";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(492, 374);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send TX";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // dgvIn
            // 
            this.dgvIn.AllowUserToAddRows = false;
            this.dgvIn.AllowUserToDeleteRows = false;
            this.dgvIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.take,
            this.amount,
            this.confirmations,
            this.Addresss,
            this.txid,
            this.vout});
            this.dgvIn.Location = new System.Drawing.Point(12, 41);
            this.dgvIn.Name = "dgvIn";
            this.dgvIn.Size = new System.Drawing.Size(868, 221);
            this.dgvIn.TabIndex = 3;
            this.dgvIn.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIn_CellMouseUp);
            this.dgvIn.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIn_CellValueChanged);
            // 
            // take
            // 
            this.take.HeaderText = "take";
            this.take.Name = "take";
            this.take.Width = 30;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 67;
            // 
            // confirmations
            // 
            this.confirmations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.confirmations.HeaderText = "confirmations";
            this.confirmations.Name = "confirmations";
            this.confirmations.ReadOnly = true;
            this.confirmations.Width = 94;
            // 
            // Addresss
            // 
            this.Addresss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Addresss.HeaderText = "Address";
            this.Addresss.Name = "Addresss";
            this.Addresss.ReadOnly = true;
            this.Addresss.Width = 70;
            // 
            // txid
            // 
            this.txid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txid.HeaderText = "TX ID";
            this.txid.Name = "txid";
            this.txid.ReadOnly = true;
            this.txid.Width = 60;
            // 
            // vout
            // 
            this.vout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vout.HeaderText = "vout";
            this.vout.Name = "vout";
            this.vout.ReadOnly = true;
            this.vout.Width = 53;
            // 
            // tbSent
            // 
            this.tbSent.Location = new System.Drawing.Point(12, 376);
            this.tbSent.Name = "tbSent";
            this.tbSent.Size = new System.Drawing.Size(100, 20);
            this.tbSent.TabIndex = 4;
            this.tbSent.Text = "0";
            // 
            // tbFee
            // 
            this.tbFee.Location = new System.Drawing.Point(118, 376);
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(100, 20);
            this.tbFee.TabIndex = 5;
            this.tbFee.Text = "0";
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(224, 376);
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(100, 20);
            this.tbOut.TabIndex = 6;
            this.tbOut.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total INs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total OUTs";
            // 
            // dgvOut
            // 
            this.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.outAmount});
            this.dgvOut.Location = new System.Drawing.Point(12, 268);
            this.dgvOut.Name = "dgvOut";
            this.dgvOut.Size = new System.Drawing.Size(868, 79);
            this.dgvOut.TabIndex = 10;
            this.dgvOut.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOut_CellValueChanged);
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address.HeaderText = "Address";
            this.Address.MaxInputLength = 50;
            this.Address.MinimumWidth = 100;
            this.Address.Name = "Address";
            // 
            // outAmount
            // 
            this.outAmount.HeaderText = "amount";
            this.outAmount.Name = "outAmount";
            // 
            // btPrepare
            // 
            this.btPrepare.Location = new System.Drawing.Point(330, 373);
            this.btPrepare.Name = "btPrepare";
            this.btPrepare.Size = new System.Drawing.Size(75, 23);
            this.btPrepare.TabIndex = 11;
            this.btPrepare.Text = "Prepare TX";
            this.btPrepare.UseVisualStyleBackColor = true;
            this.btPrepare.Click += new System.EventHandler(this.btPrepare_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Controls.Add(this.tbPass);
            this.panel1.Controls.Add(this.tbUser);
            this.panel1.Controls.Add(this.tbIp);
            this.panel1.Location = new System.Drawing.Point(268, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 103);
            this.panel1.TabIndex = 12;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(176, 36);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 7;
            this.btConnect.Text = "Connect!";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(17, 64);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(151, 20);
            this.tbPass.TabIndex = 6;
            this.tbPass.Text = "rpcpassword";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(17, 38);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(151, 20);
            this.tbUser.TabIndex = 5;
            this.tbUser.Text = "rpcuser";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(17, 12);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(151, 20);
            this.tbIp.TabIndex = 4;
            this.tbIp.Text = "ip:port";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 402);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(868, 132);
            this.tbLog.TabIndex = 13;
            // 
            // nudSelect
            // 
            this.nudSelect.Location = new System.Drawing.Point(416, 16);
            this.nudSelect.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelect.Name = "nudSelect";
            this.nudSelect.Size = new System.Drawing.Size(61, 20);
            this.nudSelect.TabIndex = 14;
            this.nudSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSelect.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(483, 12);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 15;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // bdDeselect
            // 
            this.bdDeselect.Location = new System.Drawing.Point(161, 12);
            this.bdDeselect.Name = "bdDeselect";
            this.bdDeselect.Size = new System.Drawing.Size(75, 23);
            this.bdDeselect.TabIndex = 16;
            this.bdDeselect.Text = "Deselect all";
            this.bdDeselect.UseVisualStyleBackColor = true;
            this.bdDeselect.Click += new System.EventHandler(this.bdDeselect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select first";
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(242, 12);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btSelectAll.TabIndex = 18;
            this.btSelectAll.Text = "Select all";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 546);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bdDeselect);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.nudSelect);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btPrepare);
            this.Controls.Add(this.dgvOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.tbFee);
            this.Controls.Add(this.tbSent);
            this.Controls.Add(this.dgvIn);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.btGet);
            this.Name = "main";
            this.Text = "Rav3n_pl RPC Coin Control for any coin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.DataGridView dgvIn;
        private System.Windows.Forms.TextBox tbSent;
        private System.Windows.Forms.TextBox tbFee;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOut;
        private System.Windows.Forms.Button btPrepare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn outAmount;
        private System.Windows.Forms.NumericUpDown nudSelect;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button bdDeselect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn take;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addresss;
        private System.Windows.Forms.DataGridViewTextBoxColumn txid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vout;
    }
}