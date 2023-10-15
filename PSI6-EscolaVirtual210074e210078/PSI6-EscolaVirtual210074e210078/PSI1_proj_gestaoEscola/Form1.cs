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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            //geral.Contas.Add(new contaaluno("admin", "Paulo Jorge", "admin1234"));
        }

        private void btn_login_Click(object sender, EventArgs e)
        {            
            frmadmin formadmin = new frmadmin();
            frmlogin formlogin = new frmlogin();
            

            this.Hide(); 

            if (txt_user.Text.Length == 0 || txt_pass.Text.Length == 0 || !rdb_admin.Checked && !rdb_aluno.Checked && !rdb_prof.Checked)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                formlogin.Show();
            }


            string textonum = txt_user.Text;
            string textopin = txt_pass.Text;

           

            if (rdb_admin.Checked)
            {
                if (textonum == "admin" && textopin == "admin1234")
                {
                    formadmin.Show();
                }
                else
                {
                    MessageBox.Show("Nome de usuário ou senha incorretos.", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (rdb_aluno.Checked)
                {
                    int num = Convert.ToInt16(textonum);
                    int pin = Convert.ToInt16(textopin);
                    if (geral.Contasaluno.Exists(s => s.Numconta == num))
                    {
                        contaaluno account = geral.Contasaluno.First(s => s.Numconta == num);
                        
                        if (account.Verificapin(pin))
                        {
                            frmaluno aluno = new frmaluno(account);
                            aluno.Show();
                            this.Visible = false;
                        }
                    }
                    else
                        MessageBox.Show("Não existe nenhum aluno com esse utilizador, tente outro", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (rdb_prof.Checked)
                    {
                        if (geral.Contasprof.Exists(s => s._numconta == textonum))
                        {
                            contaprof account = geral.Contasprof.First(s => s._numconta == textonum);
                            
                            if (account.Verificapin(textopin))
                            {
                                frmprof prof = new frmprof(account);
                                prof.Show();
                                this.Visible = false;
                            }
                        }
                        else
                            MessageBox.Show("Não existe nenhum aluno com esse utilizador, tente outro", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
