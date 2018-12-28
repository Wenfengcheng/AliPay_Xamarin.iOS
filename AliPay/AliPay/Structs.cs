using System;
using ObjCRuntime;

namespace AliPay
{
    [Native]
    public enum AlipayTidFactor : long
    {
        Imei,
        Imsi,
        Tid,
        Clientkey,
        Vimei,
        Vimsi,
        Clientid,
        Apdid,
        Max
    }

}
