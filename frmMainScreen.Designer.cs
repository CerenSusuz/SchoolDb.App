namespace SchoolDb.App
{
    partial class frmMainScreen
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
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnStuList = new System.Windows.Forms.Button();
            this.btnUpdateDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(51, 63);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(152, 141);
            this.btnNewStudent.TabIndex = 0;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnStuList
            // 
            this.btnStuList.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStuList.Location = new System.Drawing.Point(251, 63);
            this.btnStuList.Margin = new System.Windows.Forms.Padding(4);
            this.btnStuList.Name = "btnStuList";
            this.btnStuList.Size = new System.Drawing.Size(147, 141);
            this.btnStuList.TabIndex = 1;
            this.btnStuList.Text = "Show Student List";
            this.btnStuList.UseVisualStyleBackColor = true;
            this.btnStuList.Click += new System.EventHandler(this.btnStuList_Click);
            // 
            // btnUpdateDelete
            // 
            this.btnUpdateDelete.Location = new System.Drawing.Point(45, 291);
            this.btnUpdateDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDelete.Name = "btnUpdateDelete";
            this.btnUpdateDelete.Size = new System.Drawing.Size(353, 141);
            this.btnUpdateDelete.TabIndex = 2;
            this.btnUpdateDelete.Text = "Update  -  Delete";
            this.btnUpdateDelete.UseVisualStyleBackColor = true;
            this.btnUpdateDelete.Click += new System.EventHandler(this.btnUpdateDelete_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(441, 477);
            this.Controls.Add(this.btnUpdateDelete);
            this.Controls.Add(this.btnStuList);
            this.Controls.Add(this.btnNewStudent);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(459, 544);
            this.Name = "frmMainScreen";
            this.Text = "School Management System ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnStuList;
        private System.Windows.Forms.Button btnUpdateDelete;
    }
}