namespace FormWeek4
{
    partial class FTeacher
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvTeacher = new DataGridView();
            btnAddTeacher = new Button();
            btnDelTeacher = new Button();
            btnUptTeacher = new Button();
            ucInformation1 = new UCInformation();
            ((System.ComponentModel.ISupportInitialize)gvTeacher).BeginInit();
            SuspendLayout();
            // 
            // gvTeacher
            // 
            gvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTeacher.Location = new Point(393, 35);
            gvTeacher.Name = "gvTeacher";
            gvTeacher.RowHeadersWidth = 51;
            gvTeacher.RowTemplate.Height = 29;
            gvTeacher.Size = new Size(481, 356);
            gvTeacher.TabIndex = 1;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(78, 445);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(94, 29);
            btnAddTeacher.TabIndex = 2;
            btnAddTeacher.Text = "Add";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAdd_Click;
            // 
            // btnDelTeacher
            // 
            btnDelTeacher.Location = new Point(219, 445);
            btnDelTeacher.Name = "btnDelTeacher";
            btnDelTeacher.Size = new Size(94, 29);
            btnDelTeacher.TabIndex = 3;
            btnDelTeacher.Text = "Del";
            btnDelTeacher.UseVisualStyleBackColor = true;
            btnDelTeacher.Click += btnDel_Click;
            // 
            // btnUptTeacher
            // 
            btnUptTeacher.Location = new Point(361, 445);
            btnUptTeacher.Name = "btnUptTeacher";
            btnUptTeacher.Size = new Size(94, 29);
            btnUptTeacher.TabIndex = 4;
            btnUptTeacher.Text = "Upt";
            btnUptTeacher.UseVisualStyleBackColor = true;
            btnUptTeacher.Click += btnUpd_Click;
            // 
            // ucInformation1
            // 
            ucInformation1.Location = new Point(12, 12);
            ucInformation1.Name = "ucInformation1";
            ucInformation1.Size = new Size(375, 391);
            ucInformation1.TabIndex = 5;
            // 
            // FTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 510);
            Controls.Add(ucInformation1);
            Controls.Add(btnUptTeacher);
            Controls.Add(btnDelTeacher);
            Controls.Add(btnAddTeacher);
            Controls.Add(gvTeacher);
            Name = "FTeacher";
            Text = "FTeacher";
            ((System.ComponentModel.ISupportInitialize)gvTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView gvTeacher;
        private Button btnAddTeacher;
        private Button btnDelTeacher;
        private Button btnUptTeacher;
        private UCInformation ucInformation1;
    }
}