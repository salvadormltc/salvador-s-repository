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
    public partial class frmPerfilProf : Form
    {
        private contaprof prof;

        public frmPerfilProf(contaprof prof)
        {
            InitializeComponent();
            this.prof = prof;
        }

        private void btn_dadosPerfil_Click(object sender, EventArgs e)
        {
            //validações
            if (txt_nome.Text.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbb_disciplina.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (txt_numProf.Text.Length == 0)
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
            DialogResult result = MessageBox.Show(strMsg, "Perfil do professor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // atualiza os dados do professor no frmprof
                prof._titular = txt_nome.Text;
                prof._numconta = txt_numProf.Text;
                prof.Disciplina = cbb_disciplina.SelectedItem.ToString();

                frmprof formProf = new frmprof(prof);

                // Atualiza as labels no frmprof com os novos dados do professor
                formProf.AtualizarLabelsProf(prof);

                this.Close();
                formProf.Show();
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
