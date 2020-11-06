using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант № 7
            //1. Задано целое положительное четырехзначное число N (N > 0). 
            //Найти сумму между произведениями первых двух и последних двух его цифр.

            int a = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;

            Console.WriteLine("Задание 1\n");
        m1:
            try
            {

                Console.WriteLine("Введите целое положительное четырёхзначное число");
                a = Convert.ToInt32(Console.ReadLine());
            }            
            catch (System.FormatException)
            {
                Console.WriteLine("Введено некорректное число");
                goto m1;
            }          
            catch (System.OverflowException)
            {
                Console.WriteLine("Введено некорректное число");
                goto m1;
            }

            if(a > 999 && a < 10000)
            {
                goto m2;
            }
            else
            {
                Console.WriteLine("Введено некорректное число");
                goto m1;
            }
        m2:
            b1 = Convert.ToInt32((a * 0.001) % 10);
            b2 = Convert.ToInt32((a * 0.01) % 10);
            b3 = Convert.ToInt32((a * 0.1) % 10);
            b4 = (a % 100) % 10;

            Console.WriteLine("Сумма между произведениями первых двух и последних двух его цифр равно {0}\n\n", ((b1*b2)+(b3*b4)));

            //2. Даны три целых ненулевых числа. Найти порядковый номер меньшего из этих 3-х чисел.

            int[] mass = new int[5];
            int x = 0;
            Console.WriteLine("Введите три целых ненулевых числа");

            for (int i = 0; i < 3; i++)
            {
            m10:
                try
                {
                    Console.WriteLine("Введите {0} число", (i + 1));
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Введено некорректное число");
                    goto m10;
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Введено некорректное число");
                    goto m10;
                }
                if (x != 0)
                {
                    goto m20;
                }
                else
                {
                    Console.WriteLine("Введено некорректное число");
                    goto m10;
                }
            m20:
                mass[i] = x;
            }
            if (mass[0] < mass[1] && mass[0] < mass[2])
            {
                Console.WriteLine("Меньшее число под номером 1\n");
            }
            if (mass[1] < mass[0] && mass[1] < mass[2])
            {
                Console.WriteLine("Меньшее число под номером 2\n");
            }
            if (mass[2] < mass[0] && mass[2] < mass[1])
            {
                Console.WriteLine("Меньшее число под номером 3\n");
            }
            if (mass[2] == mass[0] && mass[2] == mass[1])
            {
                Console.WriteLine("Числа равны\n");
            }


            //3. Единицы длины пронумерованы следующим образом:
            //1 - дециметр, 2 - километр, 3 - метр, 4 - миллиметр, 5 - сантиметр. 
            //Дан номер единицы длины (целое число в диапазоне от 1 до 5) и 
            //длина отрезка в этих единицах (вещественное число). Найти длину отрезка в метрах.

            string[] arr = {"дециметрах","километрах","метрах","миллиметрах","сантиметрах" };
            int z;
            double l;
            Console.WriteLine("В каких единицах вы хотите вести длину отрезка?");
            Console.WriteLine("1 - дециметры\n2 - километры\n3 - метры\n4 - миллиметры\n5 - сантиметры\n");
        m110:
            try
            {
                z = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введено некорректное число \n\n Попробуйте ещё раз\n");
                goto m110;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Введено некорректное число \n\n Попробуйте ещё раз\n");
                goto m110;
            }
            if (z > 0 && z < 6)
            {
                goto m22;
            }
            else
            {
                Console.WriteLine("Введено некорректное число \n\n Попробуйте ещё раз\n");
                goto m110;
            }
        m22:
            try
            {
                Console.WriteLine("Введите длину отрезка в {0}", arr[z - 1]);
                l = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введено некорректное число \n\n Попробуйте ещё раз\n");
                goto m22;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Введено некорректное число \n\n Попробуйте ещё раз");
                goto m22;
            }
            switch(z)
            {
                case 1:
                    Console.WriteLine("Итого {0} дециметров равно {1} метров", l, l/10);
                    break;
                case 2:
                    Console.WriteLine("Итого {0} километров равно {1} метров", l, l * 1000);
                    break;
                case 3:
                    Console.WriteLine("Итого {0} метров", l);
                    break;
                case 4:
                    Console.WriteLine("Итого {0} миллиметров равно {1} метров", l, l / 1000);
                    break;
                case 5:
                    Console.WriteLine("Итого {0} сантиметров равно {1} метров", l, l / 100);
                    break;
            }
                
        }
    }
}
