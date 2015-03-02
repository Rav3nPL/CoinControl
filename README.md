# CoinControl
Everyone, who mine on P2Pool or solo, or use many faucets, sometimes hit a wall: how to send many coins in one transaction and not pay huge fee?

I hit this problem, when I sent few hundred transactions to exchange and kill them wallet for week :P

Because most of altcoins not have coin control form latest Bitcoin Core client, so I wrote .net app that use RPC calls to access wallet and create transactions as you like.

First, you need to enable RPC access to your coin. Edit *coin.conf file in data directory, it will need:
```
server=1
daemon=1
rpcuser=something
rpcpassword=anothersomething
```

If we not know default RPC port of coin just add:
```
rpcport=12000
```

If we have daemon not on local machine, we need allow remote RPC address to our machine
```
rpcallowip=x.x.x.x
```

If you have encrypted wallet, you need open it b4 you can sign transaction.

Typical usage:
- enter ip:port of daemon (in example: 127.0.0.1:8223), press connect
- press "get inputs"
- sort inputs by age, value or how you like
- check inputs you want to use - value will calculate in lower box and in 1st output
- enter proper output address, you can put more than one (by default it is one output... BTC address to me, a little suggestion :)
- sum of all outputs must be less or equal to inputs. If less - what`s left will be tx fee!
- then press "prepare", wait
- press "sign", wait
- press "send", wait
- after this input will be cleared

All RPC calls are in output window, so you can see and check them.

For many coins sending tx witch 0 fee is possible for older coins (mined long time ago).
To make one big input, you need do few times a loop:
- choose one address
- send 10-20 inputs to it
- loop till you have one input


If we send full many inputs to one address, we not create new one in wallet every transaction (no change every time). So one backup is enough :)

Then just create new wallet and send this one tx to it, you will have much lighter wallet file :)

I hope it will help many users.
