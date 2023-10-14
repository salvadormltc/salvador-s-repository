
namespace PSI1_proj_gestaoEscola
{
    partial class frmaluno
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
            this.lstinfoaluno = new System.Windows.Forms.ListBox();
            this.btn_editPerfil = new System.Windows.Forms.Button();
            this.grb_perfilAluno = new System.Windows.Forms.GroupBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.lbl_dataNasc = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_numAluno = new System.Windows.Forms.Label();
            this.lbl_turma = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_avaliacoes = new System.Windows.Forms.Button();
            this.grb_perfilAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstinfoaluno
            // 
            this.lstinfoaluno.FormattingEnabled = true;
            this.lstinfoaluno.Location = new System.Drawing.Point(240, 27);
            this.lstinfoaluno.Name = "lstinfoaluno";
            this.lstinfoaluno.Size = new System.Drawing.Size(289, 212);
            this.lstinfoaluno.TabIndex = 20;
            // 
            // btn_editPerfil
            // 
            this.btn_editPerfil.Location = new System.Drawing.Point(23, 220);
            this.btn_editPerfil.Name = "btn_editPerfil";
            this.btn_editPerfil.Size = new System.Drawing.Size(201, 23);
            this.btn_editPerfil.TabIndex = 19;
            this.btn_editPerfil.Text = "Editar Perfil";
            this.btn_editPerfil.UseVisualStyleBackColor = true;
            this.btn_editPerfil.Click += new System.EventHandler(this.btn_editPerfil_Click_1);
            // 
            // grb_perfilAluno
            // 
            this.grb_perfilAluno.Controls.Add(this.lbl_saldo);
            this.grb_perfilAluno.Controls.Add(this.lbl_curso);
            this.grb_perfilAluno.Controls.Add(this.lbl_dataNasc);
            this.grb_perfilAluno.Controls.Add(this.lbl_nome);
            this.grb_perfilAluno.Controls.Add(this.lbl_numAluno);
            this.grb_perfilAluno.Controls.Add(this.lbl_turma);
            this.grb_perfilAluno.Location = new System.Drawing.Point(23, 27);
            this.grb_perfilAluno.Name = "grb_perfilAluno";
            this.grb_perfilAluno.Size = new System.Drawing.Size(201, 187);
            this.grb_perfilAluno.TabIndex = 18;
            this.grb_perfilAluno.TabStop = false;
            this.grb_perfilAluno.Text = "Perfil do aluno";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(22, 153);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(40, 13);
            this.lbl_saldo.TabIndex = 17;
            this.lbl_saldo.Text = "Saldo: ";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(22, 129);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(37, 13);
            this.lbl_curso.TabIndex = 16;
            this.lbl_curso.Text = "Curso:";
            // 
            // lbl_dataNasc
            // 
            this.lbl_dataNasc.AutoSize = true;
            this.lbl_dataNasc.Location = new System.Drawing.Point(22, 79);
            this.lbl_dataNasc.Name = "lbl_dataNasc";
            this.lbl_dataNasc.Size = new System.Drawing.Size(95, 13);
            this.lbl_dataNasc.TabIndex = 7;
            this.lbl_dataNasc.Text = "Data Nascimento: ";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(22, 29);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome: ";
            // 
            // lbl_numAluno
            // 
            this.lbl_numAluno.AutoSize = true;
            this.lbl_numAluno.Location = new System.Drawing.Point(22, 54);
            this.lbl_numAluno.Name = "lbl_numAluno";
            this.lbl_numAluno.Size = new System.Drawing.Size(65, 13);
            this.lbl_numAluno.TabIndex = 5;
            this.lbl_numAluno.Text = "Num Aluno: ";
            // 
            // lbl_turma
            // 
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.Location = new System.Drawing.Point(22, 103);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(43, 13);
            this.lbl_turma.TabIndex = 3;
            this.lbl_turma.Text = "Turma: ";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(240, 249);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(289, 23);
            this.btn_sair.TabIndex = 17;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click_1);
            // 
            // btn_avaliacoes
            // 
            this.btn_avaliacoes.Location = new System.Drawing.Point(23, 249);
            this.btn_avaliacoes.Name = "btn_avaliacoes";
            this.btn_avaliacoes.Size = new System.Drawing.Size(201, 23);
            this.btn_avaliacoes.TabIndex = 16;
            this.btn_avaliacoes.Text = "Ver avaliações";
            this.btn_avaliacoes.UseVisualStyleBackColor = true;
            this.btn_avaliacoes.Click += new System.EventHandler(this.btn_avaliacoes_Click_1);
            // 
            // frmaluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 295);
            this.Controls.Add(this.lstinfoaluno);
            this.Controls.Add(this.btn_editPerfil);
            this.Controls.Add(this.grb_perfilAluno);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_avaliacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmaluno";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.frmaluno_Load);
            this.grb_perfilAluno.ResumeLayout(false);
            this.grb_perfilAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstinfoaluno;
        private System.Windows.Forms.Button btn_editPerfil;
        private System.Windows.Forms.GroupBox grb_perfilAluno;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_dataNasc;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_numAluno;
        private System.Windows.Forms.Label lbl_turma;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_avaliacoes;
        private System.Windows.Forms.Label lbl_saldo;
    }
}