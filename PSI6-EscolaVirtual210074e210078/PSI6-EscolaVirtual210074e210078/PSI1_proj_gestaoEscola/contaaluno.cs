using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI1_proj_gestaoEscola
{
    public class contaaluno
    {
        public string _numconta;
        public string _titular;
        public string _pin;
        public string _turma;
        public string _morada;
        public string _contacto;
        public string _NIF;
        public string _curso;
        public string _email;
        public string _data;
        public decimal _saldoCartao;


        public contaaluno(string numconta, string titular, string pin, string turma, string curso, string email, string data,string morada, string contacto, string NIF,decimal saldoCartao )
        {
            _numconta = numconta;
            _titular = titular;
            _pin = pin;
            _turma = turma;
            _curso = curso;
            _email = email;
            _data = data;
            _morada = morada;
            _contacto = contacto;
            _NIF = NIF;
            _saldoCartao = saldoCartao;
        }
              
        public string Numconta
        {
            get; set;
        }

        public string Titular
        {
            get; set;
        }

        public string Pin
        {
            get; set;
        }

        public string Turma
        {
            get; set;
        }

        public string Curso
        {
            get;set;
        }

        public string Email
        {
            get; set;
        }

        public string Morada
        {
            get; set;
        }

        public string Contacto
        {
            get; set;
        }

        public string NIF
        {
            get; set;
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
    }
}
