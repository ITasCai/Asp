using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentBLL;
using StudentModel;

namespace StudentManager
{
    /// <summary>
    /// DeleteStuInfo 的摘要说明
    /// </summary>
    public class DeleteStuInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            StuInfo stu = new StuInfo();
            stu.StuNo =Convert.ToInt32(context.Request["id"]);
            StuInfoManager.DelStuInfo(stu);
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