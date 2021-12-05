
namespace WindowsFormsApp2
{
    partial class Admin
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
            this.buttonGroup = new System.Windows.Forms.Button();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.buttonProfessor = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.buttonCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(47, 33);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(136, 25);
            this.buttonGroup.TabIndex = 0;
            this.buttonGroup.Text = "Student Groups";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // buttonSubject
            // 
            this.buttonSubject.Location = new System.Drawing.Point(47, 64);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(136, 25);
            this.buttonSubject.TabIndex = 1;
            this.buttonSubject.Text = "Subject";
            this.buttonSubject.UseVisualStyleBackColor = true;
            this.buttonSubject.Click += new System.EventHandler(this.buttonSubject_Click);
            // 
            // buttonProfessor
            // 
            this.buttonProfessor.Location = new System.Drawing.Point(47, 95);
            this.buttonProfessor.Name = "buttonProfessor";
            this.buttonProfessor.Size = new System.Drawing.Size(136, 25);
            this.buttonProfessor.TabIndex = 2;
            this.buttonProfessor.Text = "Professor";
            this.buttonProfessor.UseVisualStyleBackColor = true;
            this.buttonProfessor.Click += new System.EventHandler(this.buttonProfessor_Click);
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(47, 126);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(136, 25);
            this.Student.TabIndex = 3;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // buttonCourse
            // 
            this.buttonCourse.Location = new System.Drawing.Point(47, 157);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Size = new System.Drawing.Size(136, 25);
            this.buttonCourse.TabIndex = 4;
            this.buttonCourse.Text = "Course";
            this.buttonCourse.UseVisualStyleBackColor = true;
            this.buttonCourse.Click += new System.EventHandler(this.buttonCourse_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 202);
            this.Controls.Add(this.buttonCourse);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.buttonProfessor);
            this.Controls.Add(this.buttonSubject);
            this.Controls.Add(this.buttonGroup);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Button buttonProfessor;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button buttonCourse;
    }
}