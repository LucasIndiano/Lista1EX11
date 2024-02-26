using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Digite o numero equivalente a classe do animal: ");
            Console.WriteLine("Quadrupede: 1");
            Console.WriteLine("Bipede: 2");
            Console.WriteLine("Voador: 3");
            Console.WriteLine("Aquatico: 4");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Qual é o hábito alimentar de seu animal: ");
                Console.WriteLine("Carnívoro: 1");
                Console.WriteLine("Herbívoro: 2");
                b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    Console.WriteLine("Seu Animal é: Leão");
                }
                else
                {
                    Console.WriteLine("Seu Animal é: Cavalo");
                }
            }
            else if (a == 2)
            {
                Console.WriteLine("Qual é o hábito alimentar de seu animal: ");
                Console.WriteLine("Onívoro: 1");
                Console.WriteLine("Frutífero: 2");
                b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    Console.WriteLine("Seu Animal é: Homem");
                }
                else
                {
                    Console.WriteLine("Seu Animal é: Macaco");
                }
            }

            else if (a == 3) { Console.WriteLine("Seu Animal é: Morcego"); }
            else if (a == 4) { Console.WriteLine("Seu Animal é: Baleia"); }

            Console.ReadKey();
        }
    }
}
