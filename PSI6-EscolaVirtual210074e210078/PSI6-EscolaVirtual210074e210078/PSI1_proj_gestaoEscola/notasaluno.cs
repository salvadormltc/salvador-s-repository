using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1_proj_gestaoEscola
{
    public class notasaluno
    {
        public string _nota;
        public string _disciplina;
        public string _numconta;
       

        public notasaluno(string nota,string disciplina, string numconta)
        {
            _nota = nota;
            _disciplina = disciplina;
            _numconta = numconta;
            
        }

        public string Disciplina
        {
            set
            {
                if (value == " Portugues" || value == "Ingles" || value == "Matematica" || value == "Programacao (PSI)" || value == "Redes(RC)" || value == "Educacao Fisica" || value == "Area de Integracao")
                {
                    _disciplina = value;
                }
            }
            get { return _disciplina; }
        }

        public string Numconta
        {
            get; set;
        }

        public string Turma
        {
            get; set;
        }
    }
}
