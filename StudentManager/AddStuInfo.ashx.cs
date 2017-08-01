using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentModel;
using StudentDAL;
using StudentBLL;

namespace StudentManager
{
    /// <summary>
    /// AddStuInfo 的摘要说明
    /// </summary>
    public class AddStuInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            StuInfo stu = new StuInfo();
            stu.StuNo = Convert.ToInt32(context.Request["StuNo"]);
            stu.StuName = context.Request["StuName"];
            stu.StuAge = Convert.ToInt32(context.Request["StuAge"]);
            stu.StuSex = context.Request["StuSex"];
            stu.StuMajor = context.Request["StuMajor"];
            stu.StuClass = context.Request["StuClass"];
            StuInfoManager.AddStuInfo(stu);
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