
namespace WindowsFormsApp2
{
    partial class LogIn
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxStudent = new System.Windows.Forms.CheckBox();
            this.checkBoxProfesor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(67, 50);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(131, 20);
            this.textBoxUserName.TabIndex = 0;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(67, 125);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(63, 26);
            this.buttonLogIn.TabIndex = 1;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(67, 76);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(131, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log In";
            // 
            // checkBoxStudent
            // 
            this.checkBoxStudent.AutoSize = true;
            this.checkBoxStudent.Location = new System.Drawing.Point(67, 102);
            this.checkBoxStudent.Name = "checkBoxStudent";
            this.checkBoxStudent.Size = new System.Drawing.Size(63, 17);
            this.checkBoxStudent.TabIndex = 7;
            this.checkBoxStudent.TabStop = false;
            this.checkBoxStudent.Text = "Student";
            this.checkBoxStudent.UseVisualStyleBackColor = true;
            this.checkBoxStudent.CheckedChanged += new System.EventHandler(this.checkBoxStudent_CheckedChanged);
            // 
            // checkBoxProfesor
            // 
            this.checkBoxProfesor.AutoSize = true;
            this.checkBoxProfesor.Location = new System.Drawing.Point(133, 102);
            this.checkBoxProfesor.Name = "checkBoxProfesor";
            this.checkBoxProfesor.Size = new System.Drawing.Size(65, 17);
            this.checkBoxProfesor.TabIndex = 8;
            this.checkBoxProfesor.TabStop = false;
            this.checkBoxProfesor.Text = "Profesor";
            this.checkBoxProfesor.UseVisualStyleBackColor = true;
            this.checkBoxProfesor.CheckedChanged += new System.EventHandler(this.checkBoxProfesor_CheckedChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 184);
            this.Controls.Add(this.checkBoxProfesor);
            this.Controls.Add(this.checkBoxStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxStudent;
        private System.Windows.Forms.CheckBox checkBoxProfesor;
    }
}

