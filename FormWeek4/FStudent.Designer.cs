namespace FormWeek4
{
    partial class FStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvStudent = new DataGridView();
            dateBDay = new DateTimePicker();
            txtId = new TextBox();
            txtAddr = new TextBox();
            txtName = new TextBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnUpd = new Button();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtGender = new TextBox();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)gvStudent).BeginInit();
            SuspendLayout();
            // 
            // gvStudent
            // 
            gvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStudent.Location = new Point(400, 57);
            gvStudent.Name = "gvStudent";
            gvStudent.RowHeadersWidth = 51;
            gvStudent.RowTemplate.Height = 29;
            gvStudent.Size = new Size(427, 357);
            gvStudent.TabIndex = 1;
            gvStudent.CellContentClick += gvStudent_CellContentClick;
            // 
            // dateBDay
            // 
            dateBDay.Location = new Point(114, 219);
            dateBDay.Name = "dateBDay";
            dateBDay.Size = new Size(250, 27);
            dateBDay.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(114, 162);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 3;
            // 
            // txtAddr
            // 
            txtAddr.Location = new Point(114, 111);
            txtAddr.Name = "txtAddr";
            txtAddr.Size = new Size(250, 27);
            txtAddr.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(109, 480);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(252, 480);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 7;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpd
            // 
            btnUpd.Location = new Point(400, 480);
            btnUpd.Name = "btnUpd";
            btnUpd.Size = new Size(94, 29);
            btnUpd.TabIndex = 8;
            btnUpd.Text = "Upd";
            btnUpd.UseVisualStyleBackColor = true;
            btnUpd.Click += btnUpd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(114, 327);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(113, 387);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(251, 27);
            txtGender.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(544, 480);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clr";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 64);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 13;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 118);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 14;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 169);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 15;
            label3.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 226);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 16;
            label4.Text = "DOB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 280);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 17;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 334);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 18;
            label6.Text = "Phone No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 394);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 19;
            label7.Text = "Gender";
            // 
            // FStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 532);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(txtGender);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(btnUpd);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(txtAddr);
            Controls.Add(txtId);
            Controls.Add(dateBDay);
            Controls.Add(gvStudent);
            Name = "FStudent";
            Text = "FStudent";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView gvStudent;
        private DateTimePicker dateBDay;
        private TextBox txtId;
        private TextBox txtAddr;
        private TextBox txtName;
        private Button btnAdd;
        private Button btnDel;
        private Button btnUpd;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtGender;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}