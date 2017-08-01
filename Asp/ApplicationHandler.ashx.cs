using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp
{
    /// <summary>
    /// ApplicationHandler 的摘要说明
    /// </summary>
    public class ApplicationHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Application["name"] = "张三";
            context.Response.Redirect("ApplicationHandler1.ashx");
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