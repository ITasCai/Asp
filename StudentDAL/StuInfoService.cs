using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StudentModel;

namespace StudentDAL
{
   public class StuInfoService
    {
        public static List<StuInfo> GetAll() {

            List<StuInfo> list = new List<StuInfo>();
            string sql = "SELECT*FROM dbo.StuInfo";
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                StuInfo stu = new StuInfo();
                stu.StuNo = Convert.ToInt32(dr["StuNo"]);
                stu.StuName = dr["StuName"].ToString();
                stu.StuSex = dr["StuSex"].ToString();
                stu.StuAge = Convert.ToInt32(dr["StuAge"]);
                stu.StuMajor = dr["StuMajor"].ToString();
                stu.StuClass = dr["StuClass"].ToString();
                list.Add(stu);
            }
            return list;
        }

        public static int AddStuInfo(StuInfo stu) {
            string sql = "insert into StuInfo values(@stuNo,@stuName,@stuSex,@stuAge,@stuMajor,@stuClass)";
            SqlParameter[] ps = {
                new SqlParameter("@stuNo",stu.StuNo),
                new SqlParameter("@stuName",stu.StuName),
                new SqlParameter("@stuSex",stu.StuSex),
                new SqlParameter("@stuAge",stu.StuAge),
                new SqlParameter("@stuMajor",stu.StuMajor),
                new SqlParameter("@stuClass",stu.StuClass),
            };
            int count = SqlHelper.ExecuteNonQuery(CommandType.Text, sql, ps);
            return count;

        }
    }

}
