using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamus.Entities
{
    public class Dependente : Pessoa
    {
        public bool Estudante { get; set; }
        public Beneficio Beneficio { get; set; }


        public Dependente(bool estudante, Beneficio beneficio, string nome, string cpf, DateTime dataDeNascimento)
            : base(nome, cpf, dataDeNascimento)
        {
            this.Beneficio = beneficio;
            this.Estudante = estudante;
        }

        public Dependente(bool estudante, Beneficio beneficio, string nome, string email, DateTime dataDeNascimento, string cpf)
            : base (nome, email, dataDeNascimento, cpf)
        {
            Estudante = estudante;
            Beneficio = beneficio;
        }
    }
}
