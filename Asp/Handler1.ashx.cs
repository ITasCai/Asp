using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string name = context.Request["name"];
            string age = context.Request["age"];
            string isVIP = context.Request["isVIP"];


            context.Response.Write("姓名："+name+"<br/>");
            context.Response.Write("年龄："+age + "<br/>");
            if (isVIP=="on")
            {
                context.Response.Write("你是VIP");
            }
            else
            {
                context.Response.Write("你是P");
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