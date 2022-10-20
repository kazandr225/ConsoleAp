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
                int[] a = new int[n];

                //int A = 0;
                //int B = 0;

                int Asum = 0;
                int Bsum = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите {0}-й элемент \n", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine("\n");

                Console.WriteLine("Теперь выберите из элементов массива Граничные значения А и В (индексы массива), учтите, что индексы начинаются с [0]");

                Console.WriteLine("Введите A (должнен быть меньше B)");
                int Anum = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите B (должен быть больше A)");
                int Bnum = int.Parse(Console.ReadLine());


                if (Anum > Bnum)
                {
                    Console.WriteLine("В должно быть больше А, повторите ввод");
                    Console.ReadKey();
                    Console.Clear();
                    Method();
                }
                
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        //if (a[i] > 0)
                        //    sum += a[i];

                        //if (Bnum > a[i] && a[i] > Anum) //задаем границы условия
                        if (a[Bnum] > a[Anum])
                        {
                            //Asum += a[i];
                            //Bsum += a[i];

                            if (a[i] > Anum) //тут до B
                            {
                            Asum += a[i]; 
                            }

                            if (a[i] < Bnum) // тут до А
                            {
                                Bsum += a[i];
                            }

                        }
                    }
                }


                Console.WriteLine("Сумма элементов больше А: " + Asum);
                Console.WriteLine("Сумма элементов меньших В: " + Bsum);
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
