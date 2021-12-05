
namespace WindowsFormsApp2
{
    partial class AdminSubject
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAllSubject = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.GroupName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labal2 = new System.Windows.Forms.Label();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Course";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(282, 36);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCourse.TabIndex = 16;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(136, 100);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 20);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAllSubject
            // 
            this.buttonAllSubject.Location = new System.Drawing.Point(364, 100);
            this.buttonAllSubject.Name = "buttonAllSubject";
            this.buttonAllSubject.Size = new System.Drawing.Size(72, 20);
            this.buttonAllSubject.TabIndex = 14;
            this.buttonAllSubject.Text = "All Subject";
            this.buttonAllSubject.UseVisualStyleBackColor = true;
            this.buttonAllSubject.Click += new System.EventHandler(this.buttonAllSubject_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(80, 100);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 20);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.AllowUserToAddRows = false;
            this.dataGridViewSubject.AllowUserToDeleteRows = false;
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Location = new System.Drawing.Point(24, 126);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.ReadOnly = true;
            this.dataGridViewSubject.Size = new System.Drawing.Size(412, 129);
            this.dataGridViewSubject.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(24, 100);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 20);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // GroupName
            // 
            this.GroupName.AutoSize = true;
            this.GroupName.Location = new System.Drawing.Point(14, 40);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(74, 13);
            this.GroupName.TabIndex = 10;
            this.GroupName.Text = "Subject Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(94, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(118, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // labal2
            // 
            this.labal2.AutoSize = true;
            this.labal2.Location = new System.Drawing.Point(225, 66);
            this.labal2.Name = "labal2";
            this.labal2.Size = new System.Drawing.Size(51, 13);
            this.labal2.TabIndex = 19;
            this.labal2.Text = "Professor";
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(282, 63);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(154, 21);
            this.comboBoxProfessor.TabIndex = 18;
            // 
            // AdminSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 288);
            this.Controls.Add(this.labal2);
            this.Controls.Add(this.comboBoxProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAllSubject);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewSubject);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.textBoxName);
            this.Name = "AdminSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.AdminSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAllSubject;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewSubject;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labal2;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
    }
}