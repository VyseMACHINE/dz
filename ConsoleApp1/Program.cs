using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////1///////////////////////////
            /* 
            double[] b = new double[3]; 
            var rand = new Random();
            for (int k = 0; k < b.GetLength(0); k++)
            {
            b[k] = rand.Next(0, 6);
            Console.Write("  ");
            Console.Write(b[k]);
            }

            Console.ReadKey();
            */



            ///////////////////////////2///////////////////////////
            /*
           Console.WriteLine("Введите кол-во элементов:         /3 лемента/ числа/5/10/21");
           int n = int.Parse(Console.ReadLine());
           int[] a = new int[n];
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine("Введите {0}-й элемент", i + 1);
               a[i] = int.Parse(Console.ReadLine());

           }
           Console.WriteLine();
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine(a[i] + " ");
           }

           Console.ReadKey();
           */


            ///////////////////////////3///////////////////////////
            /*
            int a = 345, b = a / 100;
            Console.Write(b + " метра");
            Console.ReadKey();
            */


            ///////////////////////////4///////////////////////////
            /*
            int a = 234, b = a / 7;
            Console.Write(b + " недели");
            Console.ReadKey();
            */


            ///////////////////////////5///////////////////////////
            /*
           int a = int.Parse(Console.ReadLine());
           Console.WriteLine(
               "Число десятков {0} "+
               "Число едениц {1} "+
               "Сумма чисел {2} "+
               "Произведение цифр {3} ",
               (a / 10),
               (a % 10),
               (a / 10) + a % 10,
               (a / 10) * (a % 10));
                Console.ReadKey();
            */


            ///////////////////////////6///////////////////////////
            /*
             bool A = true;
             bool B = false;
             bool C = false;
                Console.WriteLine(A || B);

                Console.WriteLine(A && B);

                Console.WriteLine(B || C);
                Console.ReadKey();
            */


            ///////////////////////////7///////////////////////////
            /*
            Console.Write("Введите радиус круга: ");
            int a = int.Parse(Console.ReadLine());
            double s1 =  3.14 * a * a;
            Console.Write("Введите сторону квадрата: ");
            int b = int.Parse(Console.ReadLine());
            double s2 = b * b;
            if (s1 > s2)
            {
                Console.WriteLine("площадь круга больше");
            }
            else
            {
                Console.WriteLine("площадь квадрата больше");
            }
            Console.ReadKey();
            */


            ///////////////////////////8///////////////////////////
            /*
           
            Console.Write("Введите массу 1 предмета: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите массу 2 предмета: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите объем 1 предмета: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите объем 2 предмета: ");
            int b1 = int.Parse(Console.ReadLine());

            int res1 = a/a1, res2=b/b1;

            if (res1 > res2)
            {
                Console.WriteLine("плотность 1 предмета больше");
            }
            else if (res1 < res2)
            {
                Console.WriteLine("плотность 2 предмета больше");
            }
            else (res1 == res2)
            {
                Console.WriteLine("плотность 2-х предметов равна");
            }
            Console.ReadKey();
           */


            ///////////////////////////9///////////////////////////
            /*
            double i1, i2;
            Console.WriteLine("Напряжение u1 и u2 = ");
            double u1 = double.Parse(Console.ReadLine());
            double u2 = double.Parse(Console.ReadLine());
            Console.WriteLine("сопротивление r1 и r2 = ");
            double r1 = double.Parse(Console.ReadLine());
            double r2 = double.Parse(Console.ReadLine());
            i1 = u1 / r1;
            i2 = u2 / r2;

            if (i1 > i2)
            {
                Console.WriteLine("сила тока больше в 1 цепи");
            }
            else 
            {
                Console.WriteLine("сила тока больше во 2 цепи");
            }
            Console.ReadKey();
            */


            ///////////////////////////10///////////////////////////
            /*
       
            for (int i = 20; i < 35; i++)
            {
                Console.WriteLine(i+1);
            }
            Console.WriteLine();
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i < b; i++)
            {
                Console.WriteLine((i) * (i));          
            }
            Console.WriteLine();
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i < 50; i++)
            {
                Console.WriteLine((i) * (i) * (i));
            }

            Console.Write("Введите число k : ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите число j : ");
            int j = int.Parse(Console.ReadLine());
            for (; k < j; k++)
            {
                Console.WriteLine(k + 1);
            }

            Console.ReadKey();
           */

        }
    }
}
