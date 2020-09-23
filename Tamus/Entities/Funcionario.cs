using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamus.Entities
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        public DateTime DataDeContratacao { get; set; }
        public Dependente Dependente { get; set; }

        public Funcionario(string nome, string cpf)
            : base(nome, cpf)
        {

        }

        public Funcionario(DateTime dataDeContratacao, Dependente dependente, string nome, string email, DateTime dataDeNascimento, string cpf)
            : base (nome, email, dataDeNascimento, cpf)
        {
            DataDeContratacao = dataDeContratacao;
            Dependente = dependente;
        }

        public void CalculaSalario(int horasTrabalhadas, double valorDaHora) //assinatura
        {
            double salario = horasTrabalhadas * valorDaHora; //corpo 
            Salario = salario - CalculaDescontoDoBeneficio();
        }

        //sobrecarga --> polimorfismo
        public void CalculaSalario() //assinatura
        {
            Salario = Salario - CalculaDescontoDoBeneficio();
        }

        protected double CalculaDescontoDoBeneficio()
        {
            double desconto = 0;
            if (Dependente != null)
            {
                Beneficio beneficio = Dependente.Beneficio;
                int idade = Dependente.CalculaIdade();
                if (idade == 0)
                {
                    Console.WriteLine("A idade do dependente não foi fornecida!");
                }

                if ((Dependente.Estudante && idade <= 30) || (idade <= 24))
                {
                    switch(beneficio)
                    {
                        case Beneficio.PLANO_DE_SAUDE:
                            desconto = Salario * 0.04;
                            break;
                        case Beneficio.AUXILIO_EDUCACAO:
                            desconto = Salario * 0.05;
                            break;
                        case Beneficio.AUXILIO_NUTRICIONAL_E_ESPORTIVO:
                            desconto = Salario * 0.06;
                            break;
                        default:
                            desconto = 0;
                            break;
                    }
                }
            }
            return desconto;
        }
    }
}
