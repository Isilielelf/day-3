using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания (от 1 до 9):");
            int ex = int.Parse(Console.ReadLine());
            switch (ex) 
        {





                case 1:
                    Console.WriteLine("задание 1");
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                a += 5;
            }
            else if (a < 0)
            {
                a -= 5;
            }

            Console.WriteLine("Итог: " + a);
                    break;







            case 2: Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите первое число:");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int three = int.Parse(Console.ReadLine());


            if (one > two)
            {
                if (one > three)
                {
                    Console.WriteLine("Наибольшее число: " + one + "(первое число)");
                }
                else
                {

                    Console.WriteLine("Наибольшее число: " + three + "(третье число)");

                }
            }
            else
            {
                if (two > three)
                {
                    Console.WriteLine("Наибольшее число: " + two + "(второе число)");
                }
                else
                {
                    Console.WriteLine("Наибольшее число: " + three + "(третье число)");
                }

            }
                    break;







                case 3:
                    Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите первое число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int z = int.Parse(Console.ReadLine());
            int sum = 0;
            if (x > 0)
            {
                sum += x;
            }
            if (y > 0)
            {
                sum += y;
            }
            if (z > 0)
            {
                sum += z;
            }
            Console.WriteLine("Сумма положительных чисел:" + sum);
                    break;









                case 4:
                    Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число x:");
            int xn = int.Parse(Console.ReadLine());
            if (xn > 10)
            {
                int xn2 = xn * 2;
                Console.WriteLine("х больше 10, результат: " + xn2);
            }
            else
            {
                Console.WriteLine("х меньше 10, результат остается тем же: " + xn);
            }
                    break;







                case 5:  Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число:");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("День недели: понедельник");
                    break;

                case 2:
                    Console.WriteLine("День недели: вторник");
                    break;
                case 3:
                    Console.WriteLine("День недели: среда");
                    break;
                case 4:
                    Console.WriteLine("День недели: четверг");
                    break;
                case 5:
                    Console.WriteLine("День недели: пятница");
                    break;
                case 6:
                    Console.WriteLine("День недели: суббота");
                    break;
                case 7:
                    Console.WriteLine("День недели: воскресенье");
                    break;
                default: Console.WriteLine("Неподходящее число. Необходимо число от 1 до 7");
                    break;

            }
                    break;






                case 6:
            Console.WriteLine();
            Console.WriteLine("Задание 6");
            int u = 201;
            while (u % 17 != 0)
            {
                u++;
            }
            Console.WriteLine("Минимальное число больше 200, которое делится нацело на 17: " + u);
                    break;






                case 7:
                    Console.WriteLine();
            Console.WriteLine("Задание 7");
            int m = 1;
            double n = 10;
            while (n < 20)
            {
                n = n + n * 0.05;
                m++;
            }
            Console.WriteLine("Человек пробежит 20 км на " + m + " день");
            m = 1;
            n = 10;
            double totalDistance = n;
            while (totalDistance < 100)
            {
                n = n + n * 0.05;
                totalDistance += n;
                m++;
            }
            Console.WriteLine("Сумма пробега превысит 100 км на " + m + " день");
                    break;





                case 8:
                    Console.WriteLine();
            Console.WriteLine("Задание 8");
            Console.Write("Введите число(факториал): ");
            int f = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int r = 2; r <= f; r++)
            {
                fact *= r;
            }
            Console.WriteLine("Факториал числа " + f + " равен " + fact);
                    break;







                case 9:
                    Console.WriteLine();
            Console.WriteLine("Задание 9");
            Console.Write("Введите натуральное число: ");
            int num = int.Parse(Console.ReadLine());

            for (int o = 2; o <= num; o++)
            {
                if (num % o == 0)
                {
                    Console.WriteLine("Наименьший делитель числа " + num + ", отличный от 1, равен " + o);
                    break;
                }
            }
                    break;



                default:
                    Console.WriteLine("Неподходящее число. Необходимо число от 1 до 9");
                    break;
            }

            Console.ReadKey();
        }
    }
}
