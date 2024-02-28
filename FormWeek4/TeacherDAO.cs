using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWeek4
{
    class TeacherDAO
    {
        DBConnection db = new DBConnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM Teacher");
            return db.Load(sqlStr);
        }
        public void Add(Student A)
        {
            string sqlStr = string.Format("INSERT INTO Teacher(stuName, stuAddr, stuId, stuBDay, stuEmail, stuPhone, stuGender) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", A.Name, A.Addr, A.Id, A.BDay, A.Email, A.Phone, Functions.GetGender(A.Gender));
            db.Execute(sqlStr, "add");
        }

        public void Del(Student A)
        {
            string sqlStr = string.Format("DELETE FROM Teacher WHERE  stuId = '{0}'", A.Id);
            db.Execute(sqlStr, "delete");
        }

        public void Upd(Student A)
        {
            string SQL = string.Format("UPDATE Teacher SET stuName = '{0}', stuAddr ='{1}', stuBDay ='{2}', stuEmail = '{3}', stuPhone = '{4}', stuGender = '{5}' WHERE stuId = {6}", A.Name, A.Addr, A.BDay, A.Email, A.Phone, Functions.GetGender(A.Gender), A.Id);
            db.Execute(SQL, "update");
        }
    }
}
