using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentModel;
using StudentBLL;

namespace StudentManager
{
    /// <summary>
    /// RevampShowInfo 的摘要说明
    /// </summary>
    public class RevampShowInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string id = context.Request["id"];
            StuInfo stu = StuInfoManager.GetStuInfoByno(id);
            string stuinfo = stu.StuName + "," + stu.StuAge + "," + stu.StuSex + "," + stu.StuMajor + "," + stu.StuClass;
            context.Response.Write(stuinfo);
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