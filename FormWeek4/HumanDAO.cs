using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWeek4
{
    class HumanDAO
    {
        DBConnection db = new DBConnection();
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM Student");
            return db.Load(sqlStr);
            //DataTable dtStudent = new DataTable();
            //try
            //{
            //    conn.Open();
            //    string sqlStr = string.Format("SELECT * FROM Student");

            //    SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            //    adapter.Fill(dtStudent);
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            //return dtStudent;
        }
        public void Add(Human A)
        {
            string sqlStr = string.Format("INSERT INTO Student(stuName , stuAddr, stuId, stuBDay) VALUES ('{0}', '{1}', '{2}', '{3}')", A.Name, A.Addr, A.Id, A.BDay);
            db.Execute(sqlStr, "add");
            //try
            //{
            //    // Ket noi
            //    conn.Open();
            //    string sqlStr = string.Format("INSERT INTO Student(stuName , stuAddr, stuId, stuBDay) VALUES ('{0}', '{1}', '{2}', '{3}')", A.Name, A.Addr, A.Id, A.BDay);
            //    SqlCommand cmd = new SqlCommand(sqlStr, conn);
            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("add complete");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("add fail" + ex);
            //}
            //finally
            //{
            //    conn.Close();
            //    Load();
            //}
        }

        public void Del(Human A)
        {
            string sqlStr = string.Format("DELETE FROM Student WHERE stuName = '{0}' OR stuAddr = '{1}' OR stuId = '{2}' OR stuBDay = '{3}'", A.Name, A.Addr, A.Id, A.BDay);
            db.Execute(sqlStr, "delete");
            //try
            //{
            //    // Ket noi
            //    conn.Open();
            //    string sqlStr = string.Format("DELETE FROM Student WHERE stuName = '{0}' OR stuAddr = '{1}' OR stuId = '{2}' OR stuBDay = '{3}'", A.Name, A.Addr, A.Id, A.BDay);
            //    SqlCommand cmd = new SqlCommand(sqlStr, conn);
            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("del complete");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("dell fail" + ex);
            //}
            //finally
            //{
            //    conn.Close();
            //    Load();
            //}
        }

        public void Upd(Human A)
        {
            string SQL = string.Format("UPDATE Student SET stuName = '{0}', stuAddr ='{1}', stuBDay WHERE stuId = {2}", A.Name, A.Addr, A.BDay, A.Id);
            db.Execute(SQL, "update");
            //try
            //{
            //    // Ket noi
            //    conn.Open();
            //    string SQL = string.Format("UPDATE Student SET stuName = '{0}', stuAddr ='{1}', stuBDay WHERE stuId = {2}", A.Name, A.Addr, A.BDay, A.Id);
            //    SqlCommand cmd = new SqlCommand(SQL, conn);
            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("upd complete");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("upd fail" + ex);
            //}
            //finally
            //{
            //    conn.Close();
            //    Load();
            //}
        }
    }
}
