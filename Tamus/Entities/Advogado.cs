using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamus.Entities
{
    public class Advogado : Funcionario
    {
        public string Oab { get; set; }
        public string Especializacao { get; set; }

        public Advogado(string oab, string especializacao, string nome, string cpf)
            : base(nome, cpf)
        {
            Oab = oab;
            Especializacao = especializacao;
        }


        public Advogado(string oab, string especializacao, DateTime dataDeContratacao, Dependente dependente, string nome, string email, DateTime dataDeNascimento, string cpf)
            : base (dataDeContratacao, dependente, nome, email, dataDeNascimento, cpf)
        {
            Oab = oab;
            Especializacao = especializacao;
        }

        public void CalculaSalario(int horasTrabalhadas, double valorDaHora, int casosVencidos)
        {
            base.CalculaSalario(horasTrabalhadas, valorDaHora);

            const int VALOR_CASO_VENCIDO = 120;

            double adicionalCasosVencidos = casosVencidos * VALOR_CASO_VENCIDO;

            Salario = Salario + adicionalCasosVencidos - base.CalculaDescontoDoBeneficio();

        }
    }
}
