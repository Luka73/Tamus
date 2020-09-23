using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamus.Entities;

namespace Tamus
{
    public class Program
    {
        static void Main(string[] args)
        {
            Advogado advogado = new Advogado("29102-1", "Civil", "Marcos Silva", "123928302-11");
            Medico medico = new Medico("920103", "cardiologista", "Maria", "283918930-00");
            Engenheiro engenheiro = new Engenheiro("1820381", "Lucas", "162817983-12");
            Secretario secretaria = new Secretario(1900, "Talita", "371829293-43");

            Dependente depDoAdvogado = new Dependente(true, Beneficio.AUXILIO_EDUCACAO, new DateTime(2001, 9, 12), "Pedro", "210283919-92");
            Dependente depDoEngenheiro = new Dependente(false, Beneficio.PLANO_DE_SAUDE, "Larissa", "281288219-44");
            Dependente depDoMedico = new Dependente(true, Beneficio.AUXILIO_NUTRICIONAL_E_ESPORTIVO, "Enzo", "918929839-52");

            advogado.Dependente = depDoAdvogado;
            engenheiro.Dependente = depDoEngenheiro;
            medico.Dependente = depDoMedico;

            advogado.CalculaSalario(120, 30, 12);
            engenheiro.CalculaSalario(150, 32);
            medico.CalculaSalario(160, 41);
            secretaria.CalculaSalario();

            Console.WriteLine(advogado.Salario);
            Console.WriteLine(engenheiro.Salario);
            Console.WriteLine(medico.Salario);
            Console.WriteLine(secretaria.Salario);

            //Funcionario[] funcs = new Advogado[8];

            Funcionario f1 = new Advogado(); //polimorfismo
            Funcionario f2 = new Medico();
            Funcionario f3 = new Engenheiro();


            Console.ReadKey();
        }
    }
}
