using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI1_proj_gestaoEscola
{
    public partial class frmaluno : Form
    {
        private contaaluno aluno;

        public frmaluno(contaaluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;

        }

        private void frmaluno_Load(object sender, EventArgs e)
        {
            decimal _saldoCartao = Convert.ToDecimal(aluno._saldoCartao.ToString());

            lbl_nome.Text = "Nome: " + aluno._titular.ToString();
            lbl_numAluno.Text = "Num aluno: " + aluno._numconta.ToString();
            lbl_turma.Text = "Turma: " + aluno._turma.ToString();
            lbl_dataNasc.Text = aluno._data.ToString();
            lbl_curso.Text = "Curso: " + aluno._curso.ToString();                    
            lbl_saldo.Text = "Saldo: " + aluno._saldoCartao.ToString() + "€";  
        }

        private void btn_editPerfil_Click_1(object sender, EventArgs e)
        {
            frmPerfilAluno perfilAluno = new frmPerfilAluno(aluno);
            perfilAluno.Show();
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            string strMsg = "Tem a certeza que quer terminar sessão?";
            DialogResult result = MessageBox.Show(strMsg, "Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmlogin formLogin = new frmlogin();
                formLogin.Show();
            }
        }

        private void btn_avaliacoes_Click_1(object sender, EventArgs e)
        {
            foreach (var item in geral.Notasaluno)
            {
                if (item._numconta == aluno._numconta)
                {
                    lstinfoaluno.Items.Add("O aluno " + item._numconta + "  teve  " + item._nota + "  na disciplina  " + item._disciplina);
                }
            }
        }

        public void AtualizarLabelsAluno(contaaluno novoAluno)
        {
            lbl_nome.Text = novoAluno._titular;
            lbl_dataNasc.Text = novoAluno._data;
            lbl_numAluno.Text = novoAluno._numconta;
            lbl_turma.Text = novoAluno._turma;
            lbl_curso.Text = novoAluno._curso;
            lbl_saldo.Text = novoAluno._saldoCartao.ToString();
        }        
    }
}
