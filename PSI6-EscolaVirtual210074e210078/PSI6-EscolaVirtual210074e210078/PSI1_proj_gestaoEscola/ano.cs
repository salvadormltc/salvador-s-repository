using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1_proj_gestaoEscola
{
    public class ano
    {
        public int numeroano;

        public ano(int numeroano, int numeroAno, List<turma> turmas)
        {
            this.numeroano = numeroano;
            NumeroAno = numeroAno;
            Turmas = turmas;
        }

        public int NumeroAno { get; set; }
        public List<turma> Turmas { get; set; }
    }
}
