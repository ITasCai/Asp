using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentModel;
using StudentBLL;
using System.Text;
using System.Runtime.Remoting.Contexts;

namespace StudentManager
{
    /// <summary>
    /// DimShowInfo 的摘要说明
    /// </summary>
    public class DimShowInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
   
            string name = context.Request["StuName"];
            context.Response.Write(GetDimShow(name));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        public static string GetDimShow(string student) { 
            
            StringBuilder sbHtml = new StringBuilder();
     
            List<StuInfo> list = StuInfoManager.DimStu(student);

            sbHtml.Append("<tr>");
            sbHtml.Append("<td></td>");
            sbHtml.Append("<td class='xh'>学号</td>");
            sbHtml.Append("<td>姓名</td>");
            sbHtml.Append("<td>性别</td>");
            sbHtml.Append("<td>年龄</td>");
            sbHtml.Append("<td>专业</td>");
            sbHtml.Append("<td>年级</td>");
            sbHtml.Append("<td>操作</td>");
            sbHtml.Append("</tr>");

            foreach (StuInfo stu in list)
            {
                sbHtml.Append("<tr>");
                sbHtml.Append("<td><input type='checkbox'/></td>");
                sbHtml.Append("<td>" + stu.StuNo + "</td>");
                sbHtml.Append("<td>" + stu.StuName + "</td>");
                sbHtml.Append("<td>" + stu.StuSex + "</td>");
                sbHtml.Append("<td>" + stu.StuAge + "</td>");
                sbHtml.Append("<td>" + stu.StuMajor + "</td>");
                sbHtml.Append("<td>" + stu.StuClass + "</td>");
                sbHtml.Append("<td><input type='button' id='btndel'value='删除'></td>");
                sbHtml.Append("</tr>");
            }
            return sbHtml.ToString();

        }
    }
    }
