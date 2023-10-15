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
    public partial class frmPerfilAluno : Form
    {
        private contaaluno aluno;

        public frmPerfilAluno(contaaluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }       

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void btn_dadosPerfil_Click(object sender, EventArgs e)
        {
            //validações
            if (txt_nome.Text.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbb_curso.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (cbb_turma.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (txt_numAluno.Text.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_email.Text.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strMsg = "Tem a certeza que quer alterar este perfil?";
            DialogResult result = MessageBox.Show(strMsg, "Perfil do aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Atualiza os dados do aluno no frmaluno                
                aluno._titular = txt_nome.Text;
                aluno._curso = cbb_curso.SelectedItem.ToString();
                aluno._turma = cbb_turma.SelectedItem.ToString();
                aluno._numconta = txt_numAluno.Text;
                aluno._email = txt_email.Text;

                // Cria uma nova instância de frmprof
                frmaluno formAluno = new frmaluno(aluno);

                // Atualiza as labels no frmprof com os novos dados do aluno
                formAluno.AtualizarLabelsAluno(aluno);

                // Mostra o frmprof
                this.Close();
                formAluno.Show();
            }
        }
    }
}

