
namespace PSI1_proj_gestaoEscola
{
    partial class frmPerfilAluno
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
            this.grb_perfilAluno = new System.Windows.Forms.GroupBox();
            this.btn_dadosPerfil = new System.Windows.Forms.Button();
            this.cbb_curso = new System.Windows.Forms.ComboBox();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.cbb_turma = new System.Windows.Forms.ComboBox();
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.txt_numAluno = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_dataNasc = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_turma = new System.Windows.Forms.Label();
            this.lbl_numAluno = new System.Windows.Forms.Label();
            this.grb_perfilAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_perfilAluno
            // 
            this.grb_perfilAluno.Controls.Add(this.btn_dadosPerfil);
            this.grb_perfilAluno.Controls.Add(this.cbb_curso);
            this.grb_perfilAluno.Controls.Add(this.lbl_curso);
            this.grb_perfilAluno.Controls.Add(this.txt_email);
            this.grb_perfilAluno.Controls.Add(this.lbl_email);
            this.grb_perfilAluno.Controls.Add(this.cbb_turma);
            this.grb_perfilAluno.Controls.Add(this.dtp_nascimento);
            this.grb_perfilAluno.Controls.Add(this.txt_numAluno);
            this.grb_perfilAluno.Controls.Add(this.txt_nome);
            this.grb_perfilAluno.Controls.Add(this.lbl_dataNasc);
            this.grb_perfilAluno.Controls.Add(this.lbl_nome);
            this.grb_perfilAluno.Controls.Add(this.lbl_turma);
            this.grb_perfilAluno.Controls.Add(this.lbl_numAluno);
            this.grb_perfilAluno.Location = new System.Drawing.Point(21, 21);
            this.grb_perfilAluno.Name = "grb_perfilAluno";
            this.grb_perfilAluno.Size = new System.Drawing.Size(394, 233);
            this.grb_perfilAluno.TabIndex = 1;
            this.grb_perfilAluno.TabStop = false;
            this.grb_perfilAluno.Text = "Perfil do aluno";
            // 
            // btn_dadosPerfil
            // 
            this.btn_dadosPerfil.Location = new System.Drawing.Point(24, 188);
            this.btn_dadosPerfil.Name = "btn_dadosPerfil";
            this.btn_dadosPerfil.Size = new System.Drawing.Size(343, 23);
            this.btn_dadosPerfil.TabIndex = 13;
            this.btn_dadosPerfil.Text = "Gravar dados";
            this.btn_dadosPerfil.UseVisualStyleBackColor = true;
            this.btn_dadosPerfil.Click += new System.EventHandler(this.btn_dadosPerfil_Click);
            // 
            // cbb_curso
            // 
            this.cbb_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_curso.FormattingEnabled = true;
            this.cbb_curso.Items.AddRange(new object[] {
            "",
            "TG",
            "TGPSI",
            "TMA",
            "TM",
            "TSJ"});
            this.cbb_curso.Location = new System.Drawing.Point(264, 49);
            this.cbb_curso.Name = "cbb_curso";
            this.cbb_curso.Size = new System.Drawing.Size(100, 21);
            this.cbb_curso.TabIndex = 12;
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(261, 33);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(34, 13);
            this.lbl_curso.TabIndex = 11;
            this.lbl_curso.Text = "Curso";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(24, 150);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(231, 20);
            this.txt_email.TabIndex = 9;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(21, 134);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email";
            // 
            // cbb_turma
            // 
            this.cbb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_turma.FormattingEnabled = true;
            this.cbb_turma.Items.AddRange(new object[] {
            "",
            "Turma 1",
            "Turma 2",
            "Turma 3",
            "Turma 4",
            "Turma 5",
            "Turma 6"});
            this.cbb_turma.Location = new System.Drawing.Point(264, 99);
            this.cbb_turma.Name = "cbb_turma";
            this.cbb_turma.Size = new System.Drawing.Size(101, 21);
            this.cbb_turma.TabIndex = 7;
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Location = new System.Drawing.Point(24, 99);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(231, 20);
            this.dtp_nascimento.TabIndex = 6;
            // 
            // txt_numAluno
            // 
            this.txt_numAluno.Location = new System.Drawing.Point(264, 150);
            this.txt_numAluno.Name = "txt_numAluno";
            this.txt_numAluno.Size = new System.Drawing.Size(103, 20);
            this.txt_numAluno.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(24, 49);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(231, 20);
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
            // lbl_turma
            // 
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.Location = new System.Drawing.Point(261, 83);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(37, 13);
            this.lbl_turma.TabIndex = 1;
            this.lbl_turma.Text = "Turma";
            // 
            // lbl_numAluno
            // 
            this.lbl_numAluno.AutoSize = true;
            this.lbl_numAluno.Location = new System.Drawing.Point(261, 134);
            this.lbl_numAluno.Name = "lbl_numAluno";
            this.lbl_numAluno.Size = new System.Drawing.Size(59, 13);
            this.lbl_numAluno.TabIndex = 0;
            this.lbl_numAluno.Text = "Num Aluno";
            // 
            // frmPerfilAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 276);
            this.Controls.Add(this.grb_perfilAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPerfilAluno";
            this.Text = "EditarPerfilAluno";
            this.grb_perfilAluno.ResumeLayout(false);
            this.grb_perfilAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_perfilAluno;
        private System.Windows.Forms.Button btn_dadosPerfil;
        private System.Windows.Forms.ComboBox cbb_curso;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ComboBox cbb_turma;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.TextBox txt_numAluno;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_dataNasc;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_turma;
        private System.Windows.Forms.Label lbl_numAluno;
    }
}