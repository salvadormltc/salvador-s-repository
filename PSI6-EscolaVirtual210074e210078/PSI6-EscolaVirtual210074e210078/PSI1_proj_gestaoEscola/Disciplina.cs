using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1_proj_gestaoEscola
{
   public class Disciplina
    {
        public string _nome;
        public string _sigla;
        //public int _numeroAulas;

        public Disciplina(string nome, string sigla)
        {
            _nome = nome;
            _sigla = sigla;
            //_numeroAulas = numeroAulas;           
        }

        public string Nome
        { get; set; }

        public string Sigla
        { get; set; }

        //public int NumeroAulas
        //{ get; set; }
    }
}
