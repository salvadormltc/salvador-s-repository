using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1_proj_gestaoEscola
{
    public class turma
    {
        public string _numeroturma;
        public string _ano;
        public string _maxalunos;

        public turma(string numeroturma, string ano, string maxalunos)
        {
            _numeroturma = numeroturma;
            _ano = ano;
            _maxalunos = maxalunos;
        }  


        public string NumeroTurma
        { 
            get; set;
        }
        public string Ano
        { 
            get; set;
        }
        public string Maxalunos
        {
            get; set;
        }

        public List<contaaluno> Alunos { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}
