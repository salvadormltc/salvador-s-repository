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
    public partial class frmprof : Form
    {
        private contaprof prof;

        public frmprof(contaprof prof)
        {
            InitializeComponent();
            this.prof = prof;            
        }
    
        private void frmprof_Load(object sender, EventArgs e)
        {
            string disciplinas = "";
            foreach(Disciplina disciplinaAtual in prof.Disciplinas)
            {
                disciplinas += disciplinaAtual.Nome + ", ";
            }

            lbl_nome.Text = "Nome: " + prof._titular.ToString();
            lbl_numprof.Text = "Num Professor: " + prof._numconta.ToString();
            lbl_disc.Text = disciplinas;
            lbl_dataNasc.Text = prof._data.ToString();
        }

        private void btn_inserir_Click_1(object sender, EventArgs e)
        {
            string disciplinaselecionada = cbb_disciplina.SelectedItem.ToString();
            string turmaselecionadaava = cbb_turma.SelectedItem.ToString();
            /*avaliacaoaluno*/
            int numaluno = Convert.ToInt16(txtnumaluno.Text);
            string notaaluno = txtnota.Text.ToString();
            /*avaliacaoaluno*/


            if (cbb_disciplina.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (cbb_turma.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um item da lista.");
                return;
            }

            if (numaluno == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (notaaluno.Length == 0)
            {
                MessageBox.Show("Preencha os espaços devidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            TreeNode rootNode = null;

            if (rootNode == null)
            {
                rootNode = new TreeNode(turmaselecionadaava);
                trvinfo.Nodes.Add(rootNode);
            }
            foreach (TreeNode node in trvinfo.Nodes)
            {

                if (node.Text == turmaselecionadaava)
                {
                    rootNode = node;
                    break;
                }

            }

            //// Crie os nós filhos (turma, disciplina, nota) e adicione-os ao nó raiz
            //TreeNode numNode = new TreeNode( numaluno);
            //TreeNode disciplinaNode = new TreeNode("Disciplina: " + disciplinaselecionada);
            //TreeNode notaNode = new TreeNode("Nota: " + notaaluno + "v");

            //rootNode.Nodes.Add(numNode);
            //rootNode.Nodes.Add(disciplinaNode);
            //rootNode.Nodes.Add(notaNode);



            //TreeNode turmaNode = new TreeNode("Turma A");

            //// Adicionar o nó raiz à árvore
            //trvinfo.Nodes.Add(turmaNode);

            //// Criar nós para representar os alunos
            //TreeNode numNode = new TreeNode(numaluno);


            //// Adicionar os nós dos alunos como filhos do nó da turma
            //turmaNode.Nodes.Add(numNode);


            //// Criar nós para representar as disciplinas
            //TreeNode disciplinaNode = new TreeNode("Disciplina: " + disciplinaselecionada);

            //// Adicionar os nós das disciplinas como filhos dos nós dos alunos
            //numNode.Nodes.Add(disciplinaselecionada);

            //// Criar nós para representar as notas
            //TreeNode notaNode = new TreeNode("Nota: " + notaaluno + "v");

            //// Adicionar os nós das notas como filhos dos nós das disciplinas
            //numNode.Nodes.Add(disciplinaselecionada);   


            cbb_disciplina.SelectedIndex = 0;
            cbb_turma.SelectedIndex = 0;
            txtnota.Clear();
            txtnumaluno.Clear();


            geral.Notasaluno.Add(new notasaluno(notaaluno, disciplinaselecionada, numaluno));
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            string strMsg = "Tem a certeza que quer terminar sessão?";
            DialogResult result = MessageBox.Show(strMsg, "Professor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmlogin formLogin = new frmlogin();
                formLogin.Show();
            }
        }

        public void AtualizarLabelsProf(contaprof novoProf)
        {
            lbl_nome.Text = novoProf._titular;
            lbl_dataNasc.Text = novoProf._data;
            lbl_numprof.Text = novoProf._numconta;
            lbl_disc.Text = string.Join(", ", novoProf.Disciplinas);
        }        
    }
}
