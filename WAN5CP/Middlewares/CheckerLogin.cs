using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WAN5CP.Services;

namespace WAN5CP.Middlewares
{
    public class CheckerLogin
    {
        private RequestDelegate _rd;    
        private LoggerS _logger;

        public CheckerLogin(RequestDelegate rd,LoggerS ls)
        {
            _rd = rd;
          
            _logger = ls;
        }

        public async Task InvokeAsync(HttpContext _hc)
        {
            string[] path = _hc.Request.Path.ToString().ToLower().Split("/");
            if (path.Contains("api")) _hc.Response.Redirect("/login");
            else await _rd.Invoke(_hc);
        }
    }
}