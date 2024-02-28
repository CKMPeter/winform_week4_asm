using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormWeek4
{
    public partial class FTeacher : Form
    {
        public FTeacher()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        TeacherDAO teacherDAO = new TeacherDAO();

        private void Form1_Load(object sender, EventArgs e)
        {
            gvTeacher.DataSource = teacherDAO.Load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
