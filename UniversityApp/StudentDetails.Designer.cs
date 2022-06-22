
namespace University
{
    partial class StudentDetails
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
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.firstNameTextLbl = new System.Windows.Forms.Label();
            this.lastNameTextLbl = new System.Windows.Forms.Label();
            this.ageTextLbl = new System.Windows.Forms.Label();
            this.idTextLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(65, 60);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(35, 13);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(65, 97);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(49, 13);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Surname";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(65, 136);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(26, 13);
            this.ageLbl.TabIndex = 2;
            this.ageLbl.Text = "Age";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(65, 179);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(16, 13);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "Id";
            // 
            // firstNameTextLbl
            // 
            this.firstNameTextLbl.AutoSize = true;
            this.firstNameTextLbl.Location = new System.Drawing.Point(183, 60);
            this.firstNameTextLbl.Name = "firstNameTextLbl";
            this.firstNameTextLbl.Size = new System.Drawing.Size(0, 13);
            this.firstNameTextLbl.TabIndex = 4;
            // 
            // lastNameTextLbl
            // 
            this.lastNameTextLbl.AutoSize = true;
            this.lastNameTextLbl.Location = new System.Drawing.Point(183, 97);
            this.lastNameTextLbl.Name = "lastNameTextLbl";
            this.lastNameTextLbl.Size = new System.Drawing.Size(0, 13);
            this.lastNameTextLbl.TabIndex = 5;
            // 
            // ageTextLbl
            // 
            this.ageTextLbl.AutoSize = true;
            this.ageTextLbl.Location = new System.Drawing.Point(183, 136);
            this.ageTextLbl.Name = "ageTextLbl";
            this.ageTextLbl.Size = new System.Drawing.Size(0, 13);
            this.ageTextLbl.TabIndex = 6;
            // 
            // idTextLbl
            // 
            this.idTextLbl.AutoSize = true;
            this.idTextLbl.Location = new System.Drawing.Point(183, 179);
            this.idTextLbl.Name = "idTextLbl";
            this.idTextLbl.Size = new System.Drawing.Size(0, 13);
            this.idTextLbl.TabIndex = 7;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idTextLbl);
            this.Controls.Add(this.ageTextLbl);
            this.Controls.Add(this.lastNameTextLbl);
            this.Controls.Add(this.firstNameTextLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Name = "StudentDetails";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudenDetails_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label firstNameTextLbl;
        private System.Windows.Forms.Label lastNameTextLbl;
        private System.Windows.Forms.Label ageTextLbl;
        private System.Windows.Forms.Label idTextLbl;
    }
}