using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WAStudy.Models.m2;

namespace WAStudy.Middlewares
{
    public class Concierge
    {
        public RequestDelegate _rd;

        public Concierge(RequestDelegate rd)
        {
            _rd = rd;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.ToString().ToLower() == "/concierge/login") await _rd(context);
            else
            {
                string val;
                if (context.Request.Cookies.TryGetValue("Concierge", out val))
                {
                    if (!People.Check(val))
                    {                        
                        context.Response.Cookies.Delete("Concierge");
                        People.Remove(val);
                        context.Response.Redirect("/concierge/login");
                    }

                    if (await People.UpdatePerson(val)) await _rd(context);
                    else
                    {
                        context.Response.Cookies.Delete("Concierge");
                        People.Remove(val);
                        context.Response.Redirect("/concierge/login");
                    }

                }
                else context.Response.Redirect("/concierge/login");
            }
            
            
           

            
        }
    }
}