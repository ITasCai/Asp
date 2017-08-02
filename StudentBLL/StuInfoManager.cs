using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDAL;
using StudentModel;

namespace StudentBLL
{
    public class StuInfoManager
    {

       /// <summary>
       /// 查询所有学生信息
       /// </summary>
       /// <returns></returns>
        public static List<StuInfo> GetAll()
        {
            return StuInfoService.GetAll();
        }

        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public static int AddStuInfo(StuInfo stu)
        {
            return StuInfoService.AddStuInfo(stu);
        }


        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="stuNo"></param>
        /// <returns></returns>
        public static int DelStuInfo(StuInfo stu)
        {
            return StuInfoService.DelStuInfo(stu);
        }


        public static List<StuInfo> DimStu(string name)
        {
            return StuInfoService.DimStu(name);
        }

        public static int AlertStu(StuInfo stu)
        {
            return StuInfoService.AlertStu(stu);
        }

        public static StuInfo GetStuInfoByno(string stuno)
        {
            return StuInfoService.GetStuInfoByno(stuno);
        }

        }
}
