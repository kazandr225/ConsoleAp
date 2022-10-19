using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вариант 10. В одномерном массиве, состоящем из п элементов, определить количество
//и индексы элементов массива, больших А и меньших B (A<B).

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В одномерном массиве, состоящем из n элементов, определить количество и индексы элементов массива, больших А и меньших B (A<B).");
            Console.ReadKey();
            Console.Clear();

            Method();
            Console.ReadKey();
        }

        public static void Method()
        {

            try
            {
                Console.WriteLine("Введите n (положительное целое число)");
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                int[] a = new int[n];

                int A = 0;
                int B = 0;





                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите {0}-й элемент \n", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine("\n");
                Console.WriteLine("Теперь выберите из элементов массива Граничные значения А и В (индексы массива)");

                Console.WriteLine("Введите A (должнен быть меньше B)");
                int Anum = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите B (должен быть больше A)");
                int Bnum = int.Parse(Console.ReadLine());

                if (A > B)
                {
                    Console.WriteLine("В должно быть больше А, повторите ввод");
                    Console.ReadKey();
                    Console.Clear();
                    Method();
                }

                for (int i = 0; i < n; i++)
                {
                    if (a[i] > 0)
                        sum += a[i];
                }


                Console.WriteLine("Сумма положительных элементов массива: " + sum);
            }
            catch
            {
                Console.WriteLine("Возникло исключение, повторите ввод");

                Console.ReadKey();
                Console.Clear();
                Method();
            }

        }
    }
}
