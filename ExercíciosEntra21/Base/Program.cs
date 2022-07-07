using System;

namespace Base
{
    interface Operacoes
    {
        static int Somar(int a, int b)
        {
            return a + b;
        }
        static int Subtrair(int a, int b)
        {
            return a - b;
        }
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        static int Dividir(int a, int b)
        {
            return a / b;
        }

    }
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Escolha a ferramenta:");
            Console.WriteLine("1- Calculadora\n2- Sair");

        }
        static void Main(string[] args)
        {
            int opcaoCalculadora = 1;
            Console.WriteLine("Escolha a ferramenta:");
            Console.WriteLine("1- Calculadora\n2- Sair");
            int ferramenta = Convert.ToInt32(Console.ReadLine());
            while (ferramenta == 1)
            {
                while (opcaoCalculadora == 1 || opcaoCalculadora == 2 || opcaoCalculadora == 3 || opcaoCalculadora == 4)
                {
                    Console.WriteLine("1- Soma\n2- Subtração\n3- Multiplicação\n4- Divisão\n5- Voltar");
                    opcaoCalculadora = Convert.ToInt32(Console.ReadLine());
                    if (opcaoCalculadora == 1)
                    {
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Operacoes.Somar(a, b));
                    }
                    if (opcaoCalculadora == 2)
                    {
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Operacoes.Subtrair(a,b));
                    }
                    if (opcaoCalculadora == 3)
                    {
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Operacoes.Multiplicar(a, b));
                    }
                    if (opcaoCalculadora == 4)
                    {
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Operacoes.Dividir(a, b));
                    }
                }
                Menu();
                ferramenta = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}
