using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using StudentModel;
using StudentBLL;

namespace StudentManager
{
    /// <summary>
    /// SelectStudentInfoAll 的摘要说明
    /// </summary>
    public class SelectStudentInfoAll : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write(GetTabRow());

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public static string GetTabRow() {
            StringBuilder sbHtml = new StringBuilder();
            List<StuInfo> list = StuInfoManager.GetAll();
            sbHtml.Append("<tr>");
            sbHtml.Append("<td>学号</td>");
            sbHtml.Append("<td>姓名</td>");
            sbHtml.Append("<td>性别</td>");
            sbHtml.Append("<td>年龄</td>");
            sbHtml.Append("<td>专业</td>");
            sbHtml.Append("<td>年级</td>");
            sbHtml.Append("</tr>");

            foreach (StuInfo stu in list)
            {
                sbHtml.Append("<tr>");
                sbHtml.Append("<td>"+stu.StuNo+"</td>");
                sbHtml.Append("<td>"+stu.StuName+"</td>");
                sbHtml.Append("<td>"+stu.StuSex+"</td>");
                sbHtml.Append("<td>"+stu.StuAge+"</td>");
                sbHtml.Append("<td>"+stu.StuMajor+"</td>");
                sbHtml.Append("<td>"+stu.StuClass+"</td>");
                sbHtml.Append("</tr>");
            }
            return sbHtml.ToString();

        }
    }
}