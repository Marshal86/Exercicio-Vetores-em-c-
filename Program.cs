using System;

namespace ExVetor
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudantes[] v = new Estudantes[10];
            
            Console.Write("Informe o numero de quartos a serem alugados");
            int n =int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {

                Console.WriteLine("Aluguel " + i);
                
                Console.Write("Infore o nome do inquilino : ");
                string nome  = Console.ReadLine();


                Console.Write("Infore o nome do inquilino : ");
                string email = Console.ReadLine();

                Console.Write("Infore o numero do quarto : ");
                int quarto = int.Parse(Console.ReadLine());



                v[quarto] = new Estudantes(nome, email);
            }



            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados");
                for (int i = 1; i <= 10; i++)
                {
                  if(v[i] != null)
                 {
                    Console.WriteLine(i + ":" + v[i]);
                 }
                }


        }
    }
}
