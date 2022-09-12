using System;
using Microsoft.AspNetCore.Http;

namespace WAN5CP.Models.Common
{
    public class Info
    {
        public string os{ get; private set; }
        public int build_os{ get; private set; }
        public string dt_now{ get; private set; }
        public string y_ip{ get; private set; }
        public string y_post{ get; private set; }

        public Info(ConnectionInfo ci)
        {
            os = Environment.OSVersion.Platform.ToString();
            build_os = Environment.OSVersion.Version.Build;
            dt_now = DateTime.Now.ToString();
            y_ip = ci.RemoteIpAddress.ToString();
            y_post = ci.RemotePort.ToString();
        }

    }
}