using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamus.Entities
{
    public class Engenheiro : Funcionario
    {
        public string Crea { get; set; }

        public Engenheiro(string crea, string nome, string cpf)
            : base(nome, cpf)
        {
            Crea = crea;
        }

        public Engenheiro(string crea, DateTime dataDeContratacao, Dependente dependente, string nome, string email, DateTime dataDeNascimento, string cpf)
            : base(dataDeContratacao, dependente, nome, email, dataDeNascimento, cpf)
        {
            Crea = crea;
        }

        public void CalculaSalario(int horasTrabalhadas, double valorDaHora)
        {
            base.CalculaSalario(horasTrabalhadas, valorDaHora);

            Salario = Salario - base.CalculaDescontoDoBeneficio();
        }
    }
}
