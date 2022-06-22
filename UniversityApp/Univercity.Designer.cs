
namespace University
{
    partial class Univercity
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNamelbl = new System.Windows.Forms.Label();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.studentslbl = new System.Windows.Forms.Label();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.studentGv = new System.Windows.Forms.DataGridView();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentGv)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNamelbl
            // 
            this.firstNamelbl.AutoSize = true;
            this.firstNamelbl.Location = new System.Drawing.Point(24, 30);
            this.firstNamelbl.Name = "firstNamelbl";
            this.firstNamelbl.Size = new System.Drawing.Size(38, 13);
            this.firstNamelbl.TabIndex = 0;
            this.firstNamelbl.Text = "NAME";
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Location = new System.Drawing.Point(24, 61);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(65, 13);
            this.lastNamelbl.TabIndex = 1;
            this.lastNamelbl.Text = "LASTNAME";
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Location = new System.Drawing.Point(24, 92);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(29, 13);
            this.agelbl.TabIndex = 2;
            this.agelbl.Text = "AGE";
            // 
            // studentslbl
            // 
            this.studentslbl.AutoSize = true;
            this.studentslbl.Location = new System.Drawing.Point(24, 180);
            this.studentslbl.Name = "studentslbl";
            this.studentslbl.Size = new System.Drawing.Size(66, 13);
            this.studentslbl.TabIndex = 4;
            this.studentslbl.Text = "STUDENTS";
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(329, 20);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.addStudentBtn.TabIndex = 5;
            this.addStudentBtn.Text = "ADD";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // studentGv
            // 
            this.studentGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGv.Location = new System.Drawing.Point(27, 208);
            this.studentGv.Name = "studentGv";
            this.studentGv.Size = new System.Drawing.Size(482, 214);
            this.studentGv.TabIndex = 6;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(148, 23);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 7;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(148, 54);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 8;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(148, 85);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 9;
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.studentGv);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.studentslbl);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.lastNamelbl);
            this.Controls.Add(this.firstNamelbl);
            this.Name = "University";
            this.Text = "University";         
            ((System.ComponentModel.ISupportInitialize)(this.studentGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNamelbl;
        private System.Windows.Forms.Label lastNamelbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Label studentslbl;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.DataGridView studentGv;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox ageBox;
    }
}

