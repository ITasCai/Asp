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

        public static int AddStuInfo(StuInfo stu)
        {
            return StuInfoService.AddStuInfo(stu);
        }
        }
}
