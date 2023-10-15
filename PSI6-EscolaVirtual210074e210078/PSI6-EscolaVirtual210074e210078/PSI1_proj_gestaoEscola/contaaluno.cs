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
       // public string _numconta;
        public string _titular;
       // public string _pin;
        public string _turma;
        public string _morada;
       // public string _contacto;
        //public string _NIF;
        public string _curso;
        public string _email;
        //public string _data;
        private decimal _saldoCartao;

        private int _numconta;
        private int _pin;
        private int _contacto;
        private int _nif;
        private DateTime _data;
       // private turma _turma;


        public contaaluno(int numconta, string titular, int pin, string turma, string curso, string email, DateTime data, string morada, int contacto, int nif, decimal saldocartao) {
            
            _numconta = numconta;
            _titular = titular;
            _pin = pin;
            _turma = turma;
            _curso = curso;
            _email = email;
            _data = data;
            _morada = morada;
            _contacto = contacto;
            _nif = nif;
            _saldoCartao = saldocartao;
        }

       /* public contaaluno(string numconta, string titular, string pin, string turma, string curso, string email, string data,string morada, string contacto, string NIF,decimal saldoCartao )
        {
           // _numconta = numconta;
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
        }*/
              
        public int Numconta
        {
            get; set;
        }

        public string Titular
        {
            get; set;
        }

        public int Pin
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

        public int Contacto
        {
            get; set;
        }

        public int NIF
        {
            get; set;
        }

        public DateTime Data
        {
            get; set;
        }

        public decimal SaldoCartao {
            get; set;
        }

        public bool Verificapin(int pin)
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
