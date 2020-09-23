using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamus.Entities
{
    public class Secretario : Funcionario
    {

        public Secretario(double salario, string nome, string cpf)
            : base (nome, cpf)
        {
            Salario = salario;
        }


        public Secretario(double salario, Dependente dependente, string nome, string email, DateTime dataDeNascimento, string cpf)
            : base (dataDeNascimento, dependente, nome, email, dataDeNascimento, cpf)
        {
            Salario = salario;
        }
    }
}
