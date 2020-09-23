using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamus.Entities
{
    public class Medico : Funcionario
    {
        public string Crm { get; set; }
        public string Especializacao { get; set; }


        public Medico(string crm, string especializacao, string nome, string cpf)
            : base(nome, cpf)
        {
            Crm = crm;
            Especializacao = especializacao;
        }

        public Medico(string crm, string especializacao, DateTime dataDeContratacao, Dependente dependente, string nome, string email, DateTime dataDeNascimento, string cpf)
             : base(dataDeContratacao, dependente, nome, email, dataDeNascimento, cpf)
        {
            Crm = crm;
            Especializacao = especializacao;
        }

        public void CalculaSalario(int horasTrabalhadas, double valorDaHora)
        {
            base.CalculaSalario(horasTrabalhadas, valorDaHora);
            double adicionalRisco = Salario * 0.08;
            double horaExtra = 0;

            if (horasTrabalhadas > 170)
            {
                horaExtra = Salario * 0.20;
            }
            else if (horasTrabalhadas > 120)
            {
                horaExtra = Salario * 0.15;
            }

            Salario = Salario + adicionalRisco + horaExtra - base.CalculaDescontoDoBeneficio();
        }
    }
}
