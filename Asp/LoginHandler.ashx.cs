using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp
{
    /// <summary>
    /// LoginHandler 的摘要说明
    /// </summary>
    public class LoginHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string username = context.Request["username"];
            string pass= context.Request["pass"];
            if (username=="admin"&&pass=="1234")
            {
                context.Response.Redirect("correct.html");
            }
            else
            {
                context.Response.Redirect("error.html");
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}