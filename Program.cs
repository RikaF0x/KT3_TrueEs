using System.Diagnostics.CodeAnalysis;

namespace KT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task6();
        }
        static void task1()
        {
            string outp = "";
            Random rnd = new Random();
            int L = int.Parse(Console.ReadLine());
            int rnd_U = rnd.Next(0, L);
            int rnd_d = rnd.Next(0, L);
            while (rnd_d == rnd_U)
            {
                rnd_d = rnd.Next(0, L);
            }
            int rnd_A = rnd.Next(0, L);
            while (rnd_d == rnd_U || rnd_A == rnd_d)
            {
                rnd_A = rnd.Next(0, L);
            }
            for (int i = 0; i < L; i++)
            {
                if (i == rnd_U)
                {
                    outp += (char)rnd.Next(65, 91);
                }
                else if (i == rnd_d)
                {

                    outp += (char)rnd.Next(97, 123);
                }
                else if (i == rnd_A)
                {
                    outp += (char)rnd.Next(48, 58);
                }
                else
                {
                    int a = rnd.Next(0, 3);
                    if (a == 0)
                    {
                        outp += (char)rnd.Next(48, 58);
                    }
                    else if (a == 1)
                    {

                        outp += (char)rnd.Next(65, 91);
                    }
                    else if (a == 2)
                    {

                        outp += (char)rnd.Next(97, 123);
                    }
                }
            }
            Console.WriteLine(outp);
        }
        static void task2()
        {
            Random rnd = new Random();
            int A = rnd.Next(0, 101);
            int i = -1;
            while (i != A)
            {
                i = int.Parse(Console.ReadLine());
                if (i > A)
                {
                    Console.WriteLine("Меньше");
                }
                else if (i < A)
                {
                    Console.WriteLine("Больше");
                }
            }
            Console.WriteLine("Поздравляю! Вы угадали!");
            Console.Write(" n_n.-''\\\r\n<pq>  -'.\\\r\nw\\/w_w\\,./__ ldb\r\n           _)\r\n------------------------------------------------\r\nThank you for visiting https://asciiart.website/\r\nThis ASCII pic can be found at\r\nhttps://asciiart.website/art/6106");
        }
        static void task3()
        {
            Console.WriteLine("Ciracus Gipotez");
            int i = int.Parse(Console.ReadLine());
            while (i != 1)
            {
                if (i%2 == 0){
                    i = i / 2;
                }
                else
                {
                    i = i * 3 + 1;
                }
                Console.WriteLine(i);
            }
        }
        static void task4()
        {
            Console.WriteLine("Perfect arrays");
            for (int i = 1; i <= 10000; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i%j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void task5()
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            for (int i = 0; i < w; i++)
            {
                Console.Write("-");
            }
            Console.Write('\n');
            for (int i = 0; i < h-1; i++)
            {

                Console.Write("|");
                for (int j = 0; j < w - 2; j++)
                {
                    Console.Write("0");
                }
                Console.Write("|");
                Console.Write('\n');
            }

            for (int i = 0; i < w; i++)
            {
                Console.Write("-");
            }
            Console.Write('\n');
        }
        static void task6()
        {
            int i = int.Parse(Console.ReadLine());
            int[] array = new int[i];
            for (int j = 0; j < i; j++)
            {
                array[j] = j+1;
            }
            int CurA = 0;
            for (int j = 0; j*2 < i; j++)
            {
                for (int k = 0; k < j; k++)
                {
                    if (CurA < i)
                        Console.Write(array[CurA] + " ");
                    CurA++;
                    
                }
                Console.Write("\n");
            }
        }
    }
}
