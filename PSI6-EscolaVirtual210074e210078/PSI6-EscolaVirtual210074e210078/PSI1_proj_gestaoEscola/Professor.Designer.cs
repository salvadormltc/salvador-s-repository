
namespace PSI1_proj_gestaoEscola
{
    partial class frmprof
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
            this.trvinfo = new System.Windows.Forms.TreeView();
            this.btn_editPerfil = new System.Windows.Forms.Button();
            this.grb_perfilProf = new System.Windows.Forms.GroupBox();
            this.lbl_dataNasc = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_disc = new System.Windows.Forms.Label();
            this.lbl_numprof = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.grb_avaliacao = new System.Windows.Forms.GroupBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.txtnumaluno = new System.Windows.Forms.TextBox();
            this.cbb_turma = new System.Windows.Forms.ComboBox();
            this.lbl_turmAluno = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.cbb_disciplina = new System.Windows.Forms.ComboBox();
            this.lbl_numAluno = new System.Windows.Forms.Label();
            this.lbl_disciplina = new System.Windows.Forms.Label();
            this.grb_perfilProf.SuspendLayout();
            this.grb_avaliacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvinfo
            // 
            this.trvinfo.Location = new System.Drawing.Point(426, 20);
            this.trvinfo.Margin = new System.Windows.Forms.Padding(2);
            this.trvinfo.Name = "trvinfo";
            this.trvinfo.Size = new System.Drawing.Size(365, 166);
            this.trvinfo.TabIndex = 24;
            // 
            // btn_editPerfil
            // 
            this.btn_editPerfil.Location = new System.Drawing.Point(20, 191);
            this.btn_editPerfil.Name = "btn_editPerfil";
            this.btn_editPerfil.Size = new System.Drawing.Size(192, 23);
            this.btn_editPerfil.TabIndex = 23;
            this.btn_editPerfil.Text = "Editar Perfil";
            this.btn_editPerfil.UseVisualStyleBackColor = true;
            // 
            // grb_perfilProf
            // 
            this.grb_perfilProf.Controls.Add(this.lbl_dataNasc);
            this.grb_perfilProf.Controls.Add(this.lbl_nome);
            this.grb_perfilProf.Controls.Add(this.lbl_disc);
            this.grb_perfilProf.Controls.Add(this.lbl_numprof);
            this.grb_perfilProf.Location = new System.Drawing.Point(20, 20);
            this.grb_perfilProf.Margin = new System.Windows.Forms.Padding(2);
            this.grb_perfilProf.Name = "grb_perfilProf";
            this.grb_perfilProf.Padding = new System.Windows.Forms.Padding(2);
            this.grb_perfilProf.Size = new System.Drawing.Size(192, 153);
            this.grb_perfilProf.TabIndex = 22;
            this.grb_perfilProf.TabStop = false;
            this.grb_perfilProf.Text = "Perfil do professor";
            // 
            // lbl_dataNasc
            // 
            this.lbl_dataNasc.AutoSize = true;
            this.lbl_dataNasc.Location = new System.Drawing.Point(23, 57);
            this.lbl_dataNasc.Name = "lbl_dataNasc";
            this.lbl_dataNasc.Size = new System.Drawing.Size(95, 13);
            this.lbl_dataNasc.TabIndex = 19;
            this.lbl_dataNasc.Text = "Data Nascimento: ";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(23, 29);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome.TabIndex = 18;
            this.lbl_nome.Text = "Nome: ";
            // 
            // lbl_disc
            // 
            this.lbl_disc.AutoSize = true;
            this.lbl_disc.Location = new System.Drawing.Point(23, 115);
            this.lbl_disc.Name = "lbl_disc";
            this.lbl_disc.Size = new System.Drawing.Size(58, 13);
            this.lbl_disc.TabIndex = 16;
            this.lbl_disc.Text = "Disciplina: ";
            // 
            // lbl_numprof
            // 
            this.lbl_numprof.AutoSize = true;
            this.lbl_numprof.Location = new System.Drawing.Point(23, 86);
            this.lbl_numprof.Name = "lbl_numprof";
            this.lbl_numprof.Size = new System.Drawing.Size(82, 13);
            this.lbl_numprof.TabIndex = 17;
            this.lbl_numprof.Text = "Num Professor: ";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(426, 191);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(365, 23);
            this.btn_sair.TabIndex = 21;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click_1);
            // 
            // grb_avaliacao
            // 
            this.grb_avaliacao.Controls.Add(this.txtnota);
            this.grb_avaliacao.Controls.Add(this.txtnumaluno);
            this.grb_avaliacao.Controls.Add(this.cbb_turma);
            this.grb_avaliacao.Controls.Add(this.lbl_turmAluno);
            this.grb_avaliacao.Controls.Add(this.btn_inserir);
            this.grb_avaliacao.Controls.Add(this.lbl_nota);
            this.grb_avaliacao.Controls.Add(this.cbb_disciplina);
            this.grb_avaliacao.Controls.Add(this.lbl_numAluno);
            this.grb_avaliacao.Controls.Add(this.lbl_disciplina);
            this.grb_avaliacao.Location = new System.Drawing.Point(218, 20);
            this.grb_avaliacao.Name = "grb_avaliacao";
            this.grb_avaliacao.Size = new System.Drawing.Size(191, 194);
            this.grb_avaliacao.TabIndex = 20;
            this.grb_avaliacao.TabStop = false;
            this.grb_avaliacao.Text = "Avaliação";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(116, 83);
            this.txtnota.Margin = new System.Windows.Forms.Padding(2);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(58, 20);
            this.txtnota.TabIndex = 8;
            // 
            // txtnumaluno
            // 
            this.txtnumaluno.Location = new System.Drawing.Point(19, 83);
            this.txtnumaluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumaluno.Name = "txtnumaluno";
            this.txtnumaluno.Size = new System.Drawing.Size(93, 20);
            this.txtnumaluno.TabIndex = 7;
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
            this.cbb_turma.Location = new System.Drawing.Point(19, 40);
            this.cbb_turma.Name = "cbb_turma";
            this.cbb_turma.Size = new System.Drawing.Size(155, 21);
            this.cbb_turma.TabIndex = 6;
            // 
            // lbl_turmAluno
            // 
            this.lbl_turmAluno.AutoSize = true;
            this.lbl_turmAluno.Location = new System.Drawing.Point(16, 24);
            this.lbl_turmAluno.Name = "lbl_turmAluno";
            this.lbl_turmAluno.Size = new System.Drawing.Size(37, 13);
            this.lbl_turmAluno.TabIndex = 5;
            this.lbl_turmAluno.Text = "Turma";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(19, 158);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(155, 23);
            this.btn_inserir.TabIndex = 4;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click_1);
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(113, 68);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(30, 13);
            this.lbl_nota.TabIndex = 1;
            this.lbl_nota.Text = "Nota";
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
            this.cbb_disciplina.Location = new System.Drawing.Point(19, 126);
            this.cbb_disciplina.Name = "cbb_disciplina";
            this.cbb_disciplina.Size = new System.Drawing.Size(155, 21);
            this.cbb_disciplina.TabIndex = 13;
            // 
            // lbl_numAluno
            // 
            this.lbl_numAluno.AutoSize = true;
            this.lbl_numAluno.Location = new System.Drawing.Point(16, 68);
            this.lbl_numAluno.Name = "lbl_numAluno";
            this.lbl_numAluno.Size = new System.Drawing.Size(59, 13);
            this.lbl_numAluno.TabIndex = 0;
            this.lbl_numAluno.Text = "Num Aluno";
            // 
            // lbl_disciplina
            // 
            this.lbl_disciplina.AutoSize = true;
            this.lbl_disciplina.Location = new System.Drawing.Point(16, 110);
            this.lbl_disciplina.Name = "lbl_disciplina";
            this.lbl_disciplina.Size = new System.Drawing.Size(110, 13);
            this.lbl_disciplina.TabIndex = 12;
            this.lbl_disciplina.Text = "Disciplina que leciona";
            // 
            // frmprof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 241);
            this.Controls.Add(this.trvinfo);
            this.Controls.Add(this.btn_editPerfil);
            this.Controls.Add(this.grb_perfilProf);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.grb_avaliacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmprof";
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.frmprof_Load);
            this.grb_perfilProf.ResumeLayout(false);
            this.grb_perfilProf.PerformLayout();
            this.grb_avaliacao.ResumeLayout(false);
            this.grb_avaliacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvinfo;
        private System.Windows.Forms.Button btn_editPerfil;
        private System.Windows.Forms.GroupBox grb_perfilProf;
        private System.Windows.Forms.Label lbl_dataNasc;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_disc;
        private System.Windows.Forms.Label lbl_numprof;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.GroupBox grb_avaliacao;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.TextBox txtnumaluno;
        private System.Windows.Forms.ComboBox cbb_turma;
        private System.Windows.Forms.Label lbl_turmAluno;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.ComboBox cbb_disciplina;
        private System.Windows.Forms.Label lbl_numAluno;
        private System.Windows.Forms.Label lbl_disciplina;
    }
}