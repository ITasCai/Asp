using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace seccick
{
    /// <summary>
    /// test 的摘要说明
    /// </summary>
    public class test : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
          
            if (context.Session==null)
            {
                context.Response.Redirect("loginHandler.ashx");
            }
            else
            {
                string username = (string)context.Session["login"];
                context.Response.Write("欢迎你:"+username);
                object obj = context.Application["点击次数"];
                if (obj==null)
                {
                    context.Application["点击次数"]=1;
                }
                else
                {
                    int i =(int) obj;
                    i++;
                    context.Application.Lock();
                    context.Application["点击次数"] = i;
                    context.Response.Write("点击次数:"+i);
                    context.Application.UnLock();
                }
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