using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamus.Entities
{
    public abstract class Pessoa
    {
        protected string Nome { get; set; }
        protected string Email { get; set; }
        protected DateTime DataDeNascimento { get; set; } //associação
        protected string Cpf { get; set; }

        protected Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        protected Pessoa(string nome, string cpf, DateTime dataDeNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataDeNascimento = dataDeNascimento;
        }


        public Pessoa(string nome, string email, DateTime dataDeNascimento, string cpf)
        {
            Nome = nome;
            Email = email;
            DataDeNascimento = dataDeNascimento;
            Cpf = cpf;
        }

        public int CalculaIdade()
        {
            DateTime now = DateTime.Today;
            if (DataDeNascimento == null) return 0;
            int idade = now.Year - DataDeNascimento.Year;

            if (now.Month > DataDeNascimento.Month && now.Day > DataDeNascimento.Day)
            {
                idade = idade - 1;
            }

            return idade;
        }
    }
}
