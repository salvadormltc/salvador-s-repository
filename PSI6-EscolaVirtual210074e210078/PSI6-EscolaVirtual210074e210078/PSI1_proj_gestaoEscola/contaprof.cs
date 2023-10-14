﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1_proj_gestaoEscola
{
    public class contaprof
    {
        public string _titular;
        public string _numconta;
        public List<Disciplina> Disciplinas = new List<Disciplina>();
        public string _pin;
        public string _turma;
        public string _curso;
        public string _email;
        public string _data;
        public string _morada;
        public string _contacto;
        public string _NIF;


        public contaprof(string titular, string numconta, string pin, string turma, string curso, string email, string data, string morada, string contacto, string NIF, string Disciplina)
        {
            _titular = titular;
            _numconta = numconta;
            AtribuirDisciplina(Disciplina);
            _pin = pin;
            _turma = turma;
            _curso = curso;
            _email = email;
            _data = data;
            _morada = morada;
            _contacto = contacto;
            _NIF = NIF;
        }

        public string Disciplina
        {
            get;set;
        }


        public string Curso
        {
            set
            {
                if (value == "TG " || value == "TGPSI" || value == "TMA" || value == "TM" || value == "TSJ")
                {
                    _curso = value;
                }
            }
            get { return _curso; }
        }

        public bool Verificapin(string pin)
        {

            if (_pin == pin)
            {
                return true;
            }
            else
            { return false; }
        }

        public bool AtribuirDisciplina(string Disciplina)
        {         
            if(Disciplina == "Matematica")
                Disciplinas.Add(new Disciplina(Disciplina, "MAT"));

            if (Disciplina == "Portugues")
                Disciplinas.Add(new Disciplina(Disciplina, "PT"));

            if (Disciplina == "Ingles")
                Disciplinas.Add(new Disciplina(Disciplina, "ING"));

            if (Disciplina == "Programacao")
                Disciplinas.Add(new Disciplina(Disciplina, "PSI"));

            if (Disciplina == "Redes")
                Disciplinas.Add(new Disciplina(Disciplina, "RC"));

            if (Disciplina == "Educacao Fisica")
                Disciplinas.Add(new Disciplina(Disciplina, "EF"));

            if (Disciplina == "Area de Integracao")
                Disciplinas.Add(new Disciplina(Disciplina, "AI"));

            return true;
        }
    }
}
