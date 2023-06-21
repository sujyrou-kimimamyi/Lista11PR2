using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2
{
    internal class Program
    {

        public static void Ex1()
        {
            int n;
            int[] v;
            v = new int[1000];

            int s = 0;

            
            Random random = new Random();
            for (int i = 0; s != 0; i++)
            {
                v[i] = random.Next(34, 99);

                Console.WriteLine("Digite um número.");
                n = int.Parse(Console.ReadLine());

                for (int c = 0; c < 1000;)
                {
                    if (v[c] == n)
                    {
                        Console.WriteLine("Você acertou um dos números do vetor.");
                        s = 1; 
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Esse número não está presente no vetor.");
                        break;
                    }
                }
            }
        }

        public static void Ex2()
        {
            int[] v;
            v = new int[20000];

            int n, c = 0, i = 0, c2 = 0;

            Random r = new Random();

            do
            {
                i++;
                v[i] = r.Next(1, 15878);
            }
            while (i < 20000);

            Console.WriteLine("Digite um número.");
            n = int.Parse(Console.ReadLine());

            do
            {
                i++;
                if (n == v[i])
                {
                    c = c + 1;
                }
            }
            while (i < 20000);

            Console.WriteLine("O número que você digitou aparece " + c + "no vetor.");
        }

        public static void Ex3()
        {
            int[] v, v2;

            v = new int[10];
            v2 = new int[10];

            Random r = new Random();

            for(int i = 0; i < 10; i++)
            {
                v[i] = (int)r.Next(1, 500);
            }

            for(int i = 0;i < 10; i++)
            {
                if (i % 2 == 0) 
                {
                    v2[i] = v[i] / 2;
                }

                else
                {
                    v2[i] = v[i] * 3;
                }
            }

            Console.WriteLine("Primeiro vetor: " + v + "\n" + "Segundo vetor: " + v2);

        }

        public static void Ex4()
        {
            int[] v;
            v = new int[5000];

            Random r = new Random();

            for(int i = 0; i < 5000; i++)
            {
                v[i] = r.Next(1, 5000);
            }

            for (int i = 1; i < 5000; i++)
            {

                for (int c = 2; c < v[i]; c++)
                {

                    if (v[i] % c == 1)
                    {

                        Console.WriteLine("O número " + v[i] + " presente em seu vetor é primo.");
                    }
                }
            }



        }
        static void Main(string[] args)
        {

            int o;

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("opção 1 - exibir exercício 1");
                Console.WriteLine("opção 2 - exibir exercício 2");
                Console.WriteLine("opção 3 - exibir exercício 3");
                Console.WriteLine("opção 4 - exibir exercício 4");
                Console.WriteLine("opção 0 - sair");
                o = int.Parse(Console.ReadLine());

                switch(o)
                {
                    case 0:
                        Console.WriteLine("Volte sempre!");
                        break;

                    case 1:
                        Ex1();
                        break;

                    case 2:
                        Ex2();
                        break;

                    case 3:
                        Ex3();
                        break;

                    case 4:
                        Ex4();
                        break;

                    default:
                        Console.WriteLine("opção inválida. ");
                        break;
                }

            }
            while (o != 0);

        }
    }
}
