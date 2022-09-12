using System;
using Microsoft.AspNetCore.Http;
using WAN5CP.Models.Services;

namespace WAN5CP.Services
{
    public class LoggerS
    {
        public string remote_address { get; private set; }
        public int remote_port{ get; private set; }
        public string request{ get; private set; }
        public DateTime dt_request{ get; private set; }
        
        public LoggerS()
        {            
            
        }

        public void Write(HttpContext context)
        {
            remote_address = context.Connection.RemoteIpAddress.ToString();
            remote_port = context.Connection.RemotePort;
            dt_request = DateTime.Now;
            request = context.Request.Path.Value;

            RAM_LoggerS.Add(this);
        }
    }
}