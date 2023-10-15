using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSI1_proj_gestaoEscola
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
            
        }

        /*Codigo Aluno*/
        private void txtnovonumal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void txtpinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void txtsaldocartao_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void txtnifaluno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void txtcontactoaluno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void btncriaraluno_Click_1(object sender, EventArgs e)
        {
            /*aluno*/
            /* string novoaluno = txtnovonomeal.Text.ToString();
             string novaturma = cbbnovaturmaal.Text.ToString();
             string novocurso = cbbnovocursoal.Text.ToString();
             string novonum = txtnovonumal.Text.ToString();
             string novoemail = txtemailal.Text.ToString();
             string novopin = txtpinal.Text.ToString();
             string novadata = dtpdata.Text.ToString();
             string novamoral = txtmoradaaluno.Text.ToString();
             string novocontactoal = txtcontactoaluno.Text.ToString();
             string novonifal = txtnifaluno.Text.ToString();
             decimal novosaldo = Convert.ToDecimal(txtsaldocartao.Text);*/
            /*aluno*/

            string novoaluno = txtnovonomeal.Text.ToString();
            string novaturma = cbbnovaturmaal.Text.ToString();//ir buscar turma e passar objeto
            string novocurso = cbbnovocursoal.Text.ToString();
            int novonum = Convert.ToInt16(txtnovonumal.Text);
            string novoemail = txtemailal.Text.ToString();
            int novopin = Convert.ToInt16(txtpinal.Text);
            //string novadata = dtpdata.Text.ToString();
            DateTime novadata = DateTime.Parse(dtpdata.Text);
            string novamoral = txtmoradaaluno.Text.ToString();
            //string novocontactoal = txtcontactoaluno.Text.ToString();
            int novocontactoal = Convert.ToInt16(txtcontactoaluno.Text);
            //string novonifal = txtnifaluno.Text.ToString();
            int novonifal = Convert.ToInt16(txtnifaluno.Text);
            decimal novosaldo = Convert.ToDecimal(txtsaldocartao.Text);



            if (novoaluno.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbbnovaturmaal.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (cbbnovocursoal.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (novonum == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novoemail.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novopin == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novamoral.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novocontactoal == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novonifal == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtsaldocartao.Text.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (geral.Contasaluno.Exists(s => s.Numconta == novonum))
            {
                MessageBox.Show("Ja existe um númeor com essa conta, tente outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnovonumal.Focus();
                return;
            }

            txtnovonomeal.Clear();
            txtnovonumal.Clear();
            cbbnovaturmaal.SelectedIndex = 0;
            cbbnovocursoal.SelectedIndex = 0;
            txtemailprof.Clear();
            txtemailal.Clear();
            txtpinal.Clear();
            txtnifaluno.Clear();
            txtmoradaaluno.Clear();
            txtcontactoaluno.Clear();
            txtsaldocartao.Clear();


            geral.Contasaluno.Add(new contaaluno(novonum, novoaluno, novopin, novaturma, novocurso, novoemail, novadata, novamoral, novocontactoal, novonifal, novosaldo));
        }

        /*Codigo aluno*/



        /*Codigo professor*/

        private void txtpinprof_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }
        private void txtnumprof_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void btncriarprof_Click_1(object sender, EventArgs e)
        {
            /*prof*/
            string novoprof = txtnomeprof.Text.ToString();
            string novaturmaprof = cbb_turma.SelectedIndex.ToString();
            string novodisciplinaprof = cbb_disciplina.SelectedItem.ToString();
            string novocursoprof = cbbcursoprof.SelectedItem.ToString();
            string novonumprof = txtnumprof.Text.ToString();
            string novoemailprof = txtemailprof.Text.ToString();
            string novopinprof = txtpinprof.Text.ToString();
            string novadataprof = dtpdata.Text.ToString();
            string novamorprof = txtmoradaprof.Text.ToString();
            string novocontprof = txtcontprof.Text.ToString();
            string novonifprof = txtnifprof.Text.ToString();
            /*prof*/


            if (novoprof.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbb_disciplina.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (cbbcursoprof.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (cbb_turma.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (novonumprof.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novoemailprof.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novopinprof.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novamorprof.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novocontprof.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novonifprof.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (geral.Contasprof.Exists(s => s._numconta == novonumprof))
            {
                MessageBox.Show("Ja existe um número com essa conta, tente outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnumprof.Focus();
                return;
            }
                        
            //adiciona o prof a lista
            geral.Contasprof.Add(new contaprof(novoprof, novonumprof, novopinprof, novaturmaprof, novocursoprof, novoemailprof, novadataprof, novamorprof, novocontprof, novonifprof, cbb_disciplina.Text));

            txtnomeprof.Clear();
            txtpinprof.Clear();
            txtnumprof.Clear();
            cbb_disciplina.SelectedIndex = 0;
            cbb_turma.SelectedIndex = 0;
            cbbcursoprof.SelectedIndex = 0;
            txtemailal.Clear();
            txtemailprof.Clear();
            txtcontprof.Clear();
            txtmoradaprof.Clear();
            txtnifprof.Clear();
        }

        

        private void txtcontprof_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        private void txtnifprof_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }
        }

        /*Codigo professor*/



        /*Codigo turmas*/

        private void txt_numMaxAlunos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btn_criarTurma_Click(object sender, EventArgs e)
        {
            /*turmas*/
            string novoano = cbb_ano.SelectedIndex.ToString();
            string novonometurma = txt_nomeTurma.Text.ToString();
            string novonomemaxal = txt_numMaxAlunos.Text.ToString();
            /*turmas*/
                      
            if (cbb_ano.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }
            
            if (novonometurma.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novonomemaxal.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            cbb_ano.SelectedIndex = 0;
            txt_nomeTurma.Clear();
            txt_numMaxAlunos.Clear();
            
            
            //guarda as turmas adicionadas na lista de turmas
    
            cbbnovaturmaal.Items.Clear(); //limpa a cbb
            geral.TurmasAlunos.Add(new turma(novonometurma, novoano, novonomemaxal)); //adiciona nova turma na lista

            foreach (turma turmas in geral.TurmasAlunos) //atualiza a cbb - com a nova turma
            {
                cbbnovaturmaal.Items.Add(turmas._numeroturma);
            }
        }

        /*Codigo turmas*/


        private void btnsair_Click_1(object sender, EventArgs e)
        {
            string strMsg = "Tem a certeza que quer terminar sessão?";
            DialogResult result = MessageBox.Show(strMsg, "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmlogin formLogin = new frmlogin();
                formLogin.Show();
            }
        }

        private void frmadmin_VisibleChanged(object sender, EventArgs e)
        {
            //guarda as turmas adicionadas na lista de turmas

            foreach(turma turmas in geral.TurmasAlunos)
            {
                cbbnovaturmaal.Items.Add(turmas._numeroturma);
            }
        }
    }
}
