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
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <returns></returns>
        public static List<StuInfo> GetAll()
        {

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

        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public static int AddStuInfo(StuInfo stu)
        {
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


        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="stuNo"></param>
        /// <returns></returns>
        public static int DelStuInfo(StuInfo stu)
        {
            string sql = "DELETE FROM dbo.StuInfo WHERE StuNo=@StuNo";
            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@StuNo",stu.StuNo)
        };
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, pa);
        }


        public static List<StuInfo> DimStu(string name)
        {
            List<StuInfo> list = new List<StuInfo>();
            string sql = "SELECT*FROM dbo.StuInfo WHERE StuName  LIKE @StuName";
            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@StuName","%"+name+"%")
        };
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, pa);
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


        public static int AlertStu(StuInfo stu) {
            string sql = @"UPDATE dbo.StuInfo SET StuName=@StuName,StuSex=@StuSex, 
                        StuAge=@StuAge,StuMajor=@StuMajor,StuClass=@StuClass
                        WHERE StuNo=@StuNo";


            SqlParameter[] ps = {
               
                new SqlParameter("@stuName",stu.StuName),
                new SqlParameter("@stuSex",stu.StuSex),
                new SqlParameter("@stuAge",stu.StuAge),
                new SqlParameter("@stuMajor",stu.StuMajor),
                new SqlParameter("@stuClass",stu.StuClass),
                new SqlParameter("@stuNo",stu.StuNo),
            };
            int count = SqlHelper.ExecuteNonQuery(CommandType.Text, sql, ps);
            return count;
        }

        /// <summary>
        /// 根据学号查询学生信息
        /// </summary>
        /// <param name="stuno"></param>
        /// <returns></returns>
        public static StuInfo GetStuInfoByno(string stuno) {
            string sql = string.Format("SELECT*FROM dbo.StuInfo WHERE StuNo='{0}'",stuno);
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);
           
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    StuInfo stu = new StuInfo();
                    {
                        stu.StuNo = Convert.ToInt32(dr["StuNo"]);
                        stu.StuName = dr["StuName"].ToString();
                        stu.StuSex = dr["StuSex"].ToString();
                        stu.StuAge = Convert.ToInt32(dr["StuAge"]);
                        stu.StuMajor = dr["StuMajor"].ToString();
                        stu.StuClass = dr["StuClass"].ToString();
                    };
                    return stu;
                }
               
            }

            return null;
        }
    }
  }


