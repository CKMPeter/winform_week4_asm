using System.Data;
using System.Data.SqlClient;
namespace FormWeek4
{
    public partial class FStudent : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        StudentDAO studentDAO = new StudentDAO();
        public FStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvStudent.DataSource = studentDAO.Load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Functions.CheckFormatEmail(txtEmail.Text) && Functions.CheckAge(dateBDay.Value))
            {
                Student tmp = new Student(txtName.Text, txtAddr.Text, txtId.Text, dateBDay.Value, txtEmail.Text, txtPhone.Text, Functions.CheckGender(txtGender.Text));
                studentDAO.Add(tmp);
                Form1_Load(sender, e);
            }
            else
                MessageBox.Show("Add fail!\nPlease try Again!");

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Student tmp = new Student(txtName.Text, txtAddr.Text, txtId.Text, dateBDay.Value, txtEmail.Text, txtPhone.Text, Functions.CheckGender(txtGender.Text));
            studentDAO.Del(tmp);
            Form1_Load(sender, e);
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            Student tmp = new Student(txtName.Text, txtAddr.Text, txtId.Text, dateBDay.Value, txtEmail.Text, txtPhone.Text, Functions.CheckGender(txtGender.Text));
            studentDAO.Upd(tmp);
            Form1_Load(sender, e);
        }

        private void gvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = gvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAddr.Text = gvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = gvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateBDay.Value = (DateTime)gvStudent.Rows[e.RowIndex].Cells[6].Value;
            txtPhone.Text = gvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            if ((bool)gvStudent.Rows[e.RowIndex].Cells[5].Value)
                txtGender.Text = "female";
            else txtGender.Text = "male";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddr.Text = "";
            txtEmail.Text = "";
            dateBDay.Value = DateTime.Now;
            txtPhone.Text = "";
            txtGender.Text = "";
        }
    }
}