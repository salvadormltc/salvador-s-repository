
namespace PSI1_proj_gestaoEscola
{
    partial class frmlogin
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
            this.btn_login = new System.Windows.Forms.Button();
            this.grb_login = new System.Windows.Forms.GroupBox();
            this.rdb_aluno = new System.Windows.Forms.RadioButton();
            this.rdb_prof = new System.Windows.Forms.RadioButton();
            this.rdb_admin = new System.Windows.Forms.RadioButton();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.grb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(175, 110);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(128, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // grb_login
            // 
            this.grb_login.Controls.Add(this.rdb_aluno);
            this.grb_login.Controls.Add(this.rdb_prof);
            this.grb_login.Controls.Add(this.rdb_admin);
            this.grb_login.Location = new System.Drawing.Point(27, 28);
            this.grb_login.Name = "grb_login";
            this.grb_login.Size = new System.Drawing.Size(128, 105);
            this.grb_login.TabIndex = 5;
            this.grb_login.TabStop = false;
            this.grb_login.Text = "Tipo de Login";
            // 
            // rdb_aluno
            // 
            this.rdb_aluno.AutoSize = true;
            this.rdb_aluno.Location = new System.Drawing.Point(16, 70);
            this.rdb_aluno.Name = "rdb_aluno";
            this.rdb_aluno.Size = new System.Drawing.Size(52, 17);
            this.rdb_aluno.TabIndex = 2;
            this.rdb_aluno.TabStop = true;
            this.rdb_aluno.Text = "Aluno";
            this.rdb_aluno.UseVisualStyleBackColor = true;
            // 
            // rdb_prof
            // 
            this.rdb_prof.AutoSize = true;
            this.rdb_prof.Location = new System.Drawing.Point(16, 47);
            this.rdb_prof.Name = "rdb_prof";
            this.rdb_prof.Size = new System.Drawing.Size(69, 17);
            this.rdb_prof.TabIndex = 1;
            this.rdb_prof.TabStop = true;
            this.rdb_prof.Text = "Professor";
            this.rdb_prof.UseVisualStyleBackColor = true;
            // 
            // rdb_admin
            // 
            this.rdb_admin.AutoSize = true;
            this.rdb_admin.Location = new System.Drawing.Point(16, 24);
            this.rdb_admin.Name = "rdb_admin";
            this.rdb_admin.Size = new System.Drawing.Size(88, 17);
            this.rdb_admin.TabIndex = 0;
            this.rdb_admin.TabStop = true;
            this.rdb_admin.Text = "Administrador";
            this.rdb_admin.UseVisualStyleBackColor = true;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(172, 28);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(50, 13);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "Utilizador";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(172, 68);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "Password";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(175, 45);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(128, 20);
            this.txt_user.TabIndex = 8;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(175, 85);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(128, 20);
            this.txt_pass.TabIndex = 9;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 160);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.grb_login);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmlogin";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.grb_login.ResumeLayout(false);
            this.grb_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.GroupBox grb_login;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.RadioButton rdb_aluno;
        private System.Windows.Forms.RadioButton rdb_prof;
        private System.Windows.Forms.RadioButton rdb_admin;
    }
}

