
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace seccick
{
    /// <summary>
    /// loginHandler 的摘要说明
    /// </summary>
    public class loginHandler : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string name = context.Request["name"];
            string pass = context.Request["pass"];
            if (pass=="1234")
            {
                context.Session["login"] = name;
                context.Response.Redirect("test.ashx");
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