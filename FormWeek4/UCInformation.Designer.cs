namespace FormWeek4
{
    partial class UCInformation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUCGender = new TextBox();
            txtUCPhone = new TextBox();
            txtUCEmail = new TextBox();
            txtUCName = new TextBox();
            txtUCAddr = new TextBox();
            txtUCId = new TextBox();
            dateUCBDay = new DateTimePicker();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 357);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 33;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 297);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 32;
            label6.Text = "Phone No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 243);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 31;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 189);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 30;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 132);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 29;
            label3.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 81);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 28;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 27;
            label1.Text = "Full Name";
            // 
            // txtUCGender
            // 
            txtUCGender.Location = new Point(112, 350);
            txtUCGender.Name = "txtUCGender";
            txtUCGender.Size = new Size(251, 27);
            txtUCGender.TabIndex = 26;
            // 
            // txtUCPhone
            // 
            txtUCPhone.Location = new Point(113, 290);
            txtUCPhone.Name = "txtUCPhone";
            txtUCPhone.Size = new Size(250, 27);
            txtUCPhone.TabIndex = 25;
            // 
            // txtUCEmail
            // 
            txtUCEmail.Location = new Point(113, 236);
            txtUCEmail.Name = "txtUCEmail";
            txtUCEmail.Size = new Size(250, 27);
            txtUCEmail.TabIndex = 24;
            // 
            // txtUCName
            // 
            txtUCName.Location = new Point(113, 20);
            txtUCName.Name = "txtUCName";
            txtUCName.Size = new Size(250, 27);
            txtUCName.TabIndex = 23;
            // 
            // txtUCAddr
            // 
            txtUCAddr.Location = new Point(113, 74);
            txtUCAddr.Name = "txtUCAddr";
            txtUCAddr.Size = new Size(250, 27);
            txtUCAddr.TabIndex = 22;
            // 
            // txtUCId
            // 
            txtUCId.Location = new Point(113, 125);
            txtUCId.Name = "txtUCId";
            txtUCId.Size = new Size(250, 27);
            txtUCId.TabIndex = 21;
            // 
            // dateUCBDay
            // 
            dateUCBDay.Location = new Point(113, 182);
            dateUCBDay.Name = "dateUCBDay";
            dateUCBDay.Size = new Size(250, 27);
            dateUCBDay.TabIndex = 20;
            // 
            // UCInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUCGender);
            Controls.Add(txtUCPhone);
            Controls.Add(txtUCEmail);
            Controls.Add(txtUCName);
            Controls.Add(txtUCAddr);
            Controls.Add(txtUCId);
            Controls.Add(dateUCBDay);
            Name = "UCInformation";
            Size = new Size(375, 399);
            Load += UCInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUCGender;
        private TextBox txtUCPhone;
        private TextBox txtUCEmail;
        private TextBox txtUCName;
        private TextBox txtUCAddr;
        private TextBox txtUCId;
        private DateTimePicker dateUCBDay;
    }
}
