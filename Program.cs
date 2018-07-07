using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задание");
                int x;
                x = Int32.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.Clear();
                    Task1();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 2)
                {
                    Console.Clear();
                    Task2();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 3)
                {
                    Console.Clear();
                    break;
                }
            }
        }
        static void Task1()
        {
            string num1, num2;
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();

            ulong n1 = ulong.Parse(num1);
            ulong n2 = 0;

            ulong.TryParse(num1, out n1);
            ulong.TryParse(num2, out n2);

            Console.WriteLine(n1 + n2);
        }
        static void Task2()
        {
            int x,y=0;
            x = Int32.Parse(Console.ReadLine());
            char[] temp = new char[x.ToString().Length];

            //  Convert.ToInt32(temp.ToString());
            temp = x.ToString().ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                y = y + (int)temp[i]-48;
            }
            Console.WriteLine(y);
        }
    }
}