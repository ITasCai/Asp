using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp
{
    /// <summary>
    /// TestHandler1 的摘要说明
    /// </summary>
    public class TestHandler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write("<font color='red'> Hello World</font>");
            string action = context.Request["name"];
            int age = Convert.ToInt32(context.Request["age"]);
            context.Response.Write("我叫："+action);
            context.Response.Write("年龄：" + age);

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