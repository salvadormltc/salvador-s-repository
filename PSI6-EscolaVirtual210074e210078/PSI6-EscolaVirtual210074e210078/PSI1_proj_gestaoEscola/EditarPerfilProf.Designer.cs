
namespace PSI1_proj_gestaoEscola
{
    partial class frmPerfilProf
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
            this.grb_perfilProf = new System.Windows.Forms.GroupBox();
            this.btn_dadosPerfil = new System.Windows.Forms.Button();
            this.cbb_disciplina = new System.Windows.Forms.ComboBox();
            this.lbl_disciplina = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.txt_numProf = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_dataNasc = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_numProf = new System.Windows.Forms.Label();
            this.grb_perfilProf.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_perfilProf
            // 
            this.grb_perfilProf.Controls.Add(this.btn_dadosPerfil);
            this.grb_perfilProf.Controls.Add(this.cbb_disciplina);
            this.grb_perfilProf.Controls.Add(this.lbl_disciplina);
            this.grb_perfilProf.Controls.Add(this.txt_email);
            this.grb_perfilProf.Controls.Add(this.lbl_email);
            this.grb_perfilProf.Controls.Add(this.dtp_nascimento);
            this.grb_perfilProf.Controls.Add(this.txt_numProf);
            this.grb_perfilProf.Controls.Add(this.txt_nome);
            this.grb_perfilProf.Controls.Add(this.lbl_dataNasc);
            this.grb_perfilProf.Controls.Add(this.lbl_nome);
            this.grb_perfilProf.Controls.Add(this.lbl_numProf);
            this.grb_perfilProf.Location = new System.Drawing.Point(22, 23);
            this.grb_perfilProf.Name = "grb_perfilProf";
            this.grb_perfilProf.Size = new System.Drawing.Size(298, 284);
            this.grb_perfilProf.TabIndex = 2;
            this.grb_perfilProf.TabStop = false;
            this.grb_perfilProf.Text = "Perfil do professor";
            // 
            // btn_dadosPerfil
            // 
            this.btn_dadosPerfil.Location = new System.Drawing.Point(24, 239);
            this.btn_dadosPerfil.Name = "btn_dadosPerfil";
            this.btn_dadosPerfil.Size = new System.Drawing.Size(251, 23);
            this.btn_dadosPerfil.TabIndex = 13;
            this.btn_dadosPerfil.Text = "Gravar dados";
            this.btn_dadosPerfil.UseVisualStyleBackColor = true;
            this.btn_dadosPerfil.Click += new System.EventHandler(this.btn_dadosPerfil_Click);
            // 
            // cbb_disciplina
            // 
            this.cbb_disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_disciplina.FormattingEnabled = true;
            this.cbb_disciplina.Items.AddRange(new object[] {
            "",
            "Portugues",
            "Ingles",
            "Matematica",
            "Programacao (PSI)",
            "Redes (RC)",
            "Educacao Fisica",
            "Area de Integracao"});
            this.cbb_disciplina.Location = new System.Drawing.Point(24, 150);
            this.cbb_disciplina.Name = "cbb_disciplina";
            this.cbb_disciplina.Size = new System.Drawing.Size(124, 21);
            this.cbb_disciplina.TabIndex = 12;
            // 
            // lbl_disciplina
            // 
            this.lbl_disciplina.AutoSize = true;
            this.lbl_disciplina.Location = new System.Drawing.Point(21, 134);
            this.lbl_disciplina.Name = "lbl_disciplina";
            this.lbl_disciplina.Size = new System.Drawing.Size(52, 13);
            this.lbl_disciplina.TabIndex = 11;
            this.lbl_disciplina.Text = "Disciplina";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(24, 202);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(251, 20);
            this.txt_email.TabIndex = 9;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(21, 186);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email";
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Location = new System.Drawing.Point(24, 99);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(251, 20);
            this.dtp_nascimento.TabIndex = 6;
            // 
            // txt_numProf
            // 
            this.txt_numProf.Location = new System.Drawing.Point(163, 150);
            this.txt_numProf.Name = "txt_numProf";
            this.txt_numProf.Size = new System.Drawing.Size(112, 20);
            this.txt_numProf.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(24, 49);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(251, 20);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // lbl_dataNasc
            // 
            this.lbl_dataNasc.AutoSize = true;
            this.lbl_dataNasc.Location = new System.Drawing.Point(21, 83);
            this.lbl_dataNasc.Name = "lbl_dataNasc";
            this.lbl_dataNasc.Size = new System.Drawing.Size(104, 13);
            this.lbl_dataNasc.TabIndex = 3;
            this.lbl_dataNasc.Text = "Data de Nascimento";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(21, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_numProf
            // 
            this.lbl_numProf.AutoSize = true;
            this.lbl_numProf.Location = new System.Drawing.Point(160, 134);
            this.lbl_numProf.Name = "lbl_numProf";
            this.lbl_numProf.Size = new System.Drawing.Size(76, 13);
            this.lbl_numProf.TabIndex = 0;
            this.lbl_numProf.Text = "Num Professor";
            // 
            // frmPerfilProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 319);
            this.Controls.Add(this.grb_perfilProf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPerfilProf";
            this.Text = "EditarPerfilProf";
            this.grb_perfilProf.ResumeLayout(false);
            this.grb_perfilProf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_perfilProf;
        private System.Windows.Forms.Button btn_dadosPerfil;
        private System.Windows.Forms.ComboBox cbb_disciplina;
        private System.Windows.Forms.Label lbl_disciplina;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.TextBox txt_numProf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_dataNasc;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_numProf;
    }
}