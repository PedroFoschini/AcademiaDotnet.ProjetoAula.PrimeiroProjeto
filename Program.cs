using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet.ConsoleApp
{
    internal class Program
    {
        enum DiasUteis
        {
            SegundaFeira = 1,
            TercaFeira = 2,
            QuartaFeira = 3,
            QuintaFeira = 4,
            SextaFeira = 5
        };

        static void Main(string[] args)
        {
         //   var nomeCorrentista = "";
         //   Console.WriteLine("Informe o nome do correntista:");
                    
         //   nomeCorrentista = Console.ReadLine();
         //   Console.Write("Nome da variável = " + nomeCorrentista);
         //    Console.ReadLine();

         //   Convert.ToInt32("10");

         //   double saldo = 100.0;
         //   saldo -= 10;
         //   Console.Write("O saldo atual é: " + saldo);
         //   Console.ReadLine();


         //   String[] nomes = new string[2] {"Fulano da Silva", "Beltrano da Silva"};
         //   nomes[0] = "Fulano da Silva";
         //   nomes[1] = "Beltrano da Silva";

         //   Console.Write("O valor da posição 0 é: " + nomes[0]);
         //   Console.Read();

         //   List<String> nomezes = new List<String>();
         //   nomezes.Add("Fulano da Silva");
         //   nomezes.Add("Beltrano da Silva");
         //    nomezes.Add("Ray");


         //   bool existeNaLista = nomezes.Contains("Ray");



         //   int diaSemana = (int)DiasUteis.SegundaFeira;
         //   int diaSemana = Convert.ToInt32(DiasUteis.SegundaFeira);

         //   Console.Write("Hoje é: " + diaSemana);
         //   Console.Read();

         //   int tamanho = 10;
         //   for (int i = 0; i < tamanho; i++)
         //   {
         //       Console.Write("O valor da variável i é: " + i + "\n");
         //   }
         //   Console.ReadKey();

         //   double saldoConta =  100.0;
         //   Console.Write("Digite um valor para debitar da sua conta:");
         //   var debitar = Convert.ToDouble(Console.ReadLine());

         //   saldoConta -= debitar;

         //   switch (saldoConta)
	     //   {
		 //       case 50.0:
         //           Console.Write("Você debitou 50 da sua conta !");
         //           break;
         //       case 10.0:
         //           Console.Write("Você debitou 90 da sua conta!!!");
         //           break;
         //       case 75.0:
         //           Console.Write("Você debitou 25 da sua conta !!");
         //           break;
         //       default:
         //           Console.Write("Você debitou {0} da sua conta", debitar);
         //           break;
	     //   }

         //   if(saldoConta > debitar && debitar > 0)
         //   {
         //       saldoConta -= debitar;
         //       Console.Write("Saque efetuado no valor de: R$" + debitar);
         //   }
         //   else
         //   {
         //       Console.Write("Saldo insuficiente");
         //   };
            
         //   Console.ReadKey();

         //   List<String> nomes = new List<String> {"Ray Carneiro", "Pollyana Carneiro", "Fernando Mendes" };

         //   foreach (String nome in nomes)
         //   {
         //       Console.WriteLine("O nome da pessoa é: " + nome);
         //   }

         //   Console.ReadKey();

         Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Ray Carneiro";
            pessoa1.cpf = "111.111.111-11";
            pessoa1.numeroContaCorrente = "123456789";

         Pessoa pessoa2 = new Pessoa();
            pessoa2.nome = "Fulano da Silva";
            pessoa2.cpf = "222.222.222-22";
            pessoa2.numeroContaCorrente = "987654321";

            Pessoa pessoa3 = new Pessoa()
            {
                nome = "Beltrano da Silva",
                cpf = "333.333.333-33",
                numeroContaCorrente = "456123789"
            };

            List<Pessoa> listaPessoas = new List<Pessoa>();

            listaPessoas.Add(pessoa1);
            listaPessoas.Add(pessoa2);
            listaPessoas.Add(pessoa3);

            foreach(var pessoa in listaPessoas)
            {
                Console.WriteLine("O nome da pessoa é: " + pessoa.nome);
            };

            Console.ReadKey();

        }
    }
}
