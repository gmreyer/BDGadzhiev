
namespace AgilCourse
{
    partial class UserInfoForm
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
            this.postTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryTB = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // postTB
            // 
            this.postTB.Location = new System.Drawing.Point(83, 78);
            this.postTB.Name = "postTB";
            this.postTB.ReadOnly = true;
            this.postTB.Size = new System.Drawing.Size(100, 20);
            this.postTB.TabIndex = 5;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(83, 52);
            this.ageTB.Name = "ageTB";
            this.ageTB.ReadOnly = true;
            this.ageTB.Size = new System.Drawing.Size(100, 20);
            this.ageTB.TabIndex = 4;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(83, 26);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgilCourse.Properties.Resources.User_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(200, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Зарплата";
            // 
            // salaryTB
            // 
            this.salaryTB.Location = new System.Drawing.Point(83, 104);
            this.salaryTB.Name = "salaryTB";
            this.salaryTB.ReadOnly = true;
            this.salaryTB.Size = new System.Drawing.Size(100, 20);
            this.salaryTB.TabIndex = 11;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(165, 130);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(143, 23);
            this.logout.TabIndex = 13;
            this.logout.Text = "Выйти из учетной записи";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 160);
            this.ControlBox = false;
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaryTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.postTB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.nameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salaryTB;
        private System.Windows.Forms.Button logout;
    }
}