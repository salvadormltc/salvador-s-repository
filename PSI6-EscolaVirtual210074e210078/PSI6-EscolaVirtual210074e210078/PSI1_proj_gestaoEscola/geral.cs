using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1_proj_gestaoEscola
{
    public static class geral
    {
        public static List<contaaluno> Contasaluno 
        { 
            get; set;
        }
        public static List<contaprof> Contasprof
        { 
            get; set;
        }
        public static List<notasaluno> Notasaluno
        {
            get; set;
        }
        public static List<turma> TurmasAlunos
        {
            get; set;
        }

        static geral()
        {
            /*notas alunos*/
            Notasaluno= new List<notasaluno>();
            Notasaluno.Add(new notasaluno("19", "Matematica", 210078));
            /*notas alunos*/

            /*turmas*/
            TurmasAlunos = new List<turma>()
            {
                new turma ("Turma 1", "10ºano", "20"),
                new turma ("Turma 2", "10ºano", "20"),
                new turma ("Turma 3", "11ºano", "20"),
                new turma ("Turma 4", "11ºano", "20"),
                new turma ("Turma 5", "12ºano", "20"),
                new turma ("Turma 6", "12ºano", "20"),
            };
            /*turmas*/

            /*alunos*/
            //Contasaluno = new List<contaaluno>();
            //Contasaluno.Add(new contaaluno("210078","Salvador", "1234","Turma 2","TGPSI","email@email.com","dataAluno","moradaAluno","968601853","8348758375",89));
            
            Contasaluno = new List<contaaluno>();
            DateTime data = DateTime.Now;
            Contasaluno.Add(new contaaluno(210074, "Raquel", 1234, "Turma 3", "TGPSI", "email@aluno.com", data, "moradaAluno", 968601883, 123456789, 100));
            /*alunos*/

            /*profs*/
            Contasprof = new List<contaprof>();
            //Contasprof.Add(new contaprof("Mario","210079","1234","Turma 2","TGPSI","email@prof.com","dataProf","moradaProf","975687687","88787789"));
            /*profs*/
        }
    }
}
