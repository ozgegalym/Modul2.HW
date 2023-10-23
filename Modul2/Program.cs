using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите текст: ");

                char input;
                int spaceCount = 0;

                do
                {
                    input = Console.ReadKey().KeyChar;

                    if (input == ' ')
                    {
                        spaceCount++;
                    }

                } while (input != '.');

                Console.WriteLine(); // Перевод строки для чистоты вывода
                Console.WriteLine($"Количество пробелов: {spaceCount}");
            }
        }
    }

/*
//4
using System;
namespace Modul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("В = ");
            int B = int.Parse(Console.ReadLine());

            if (A >= B)
            {
                Console.WriteLine("B должно быть больше A.");
                return;
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
       
    }
    }
}

    //Esep 5
    using System;
    namespace Modul2
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Console.Write("N =  ");
                int N = int.Parse(Console.ReadLine());

                if (N <= 0)
                {
                    Console.WriteLine("Число N должно быть больше 0.");
                    return;
                }

                int reversedN = 0;
                int originalN = N;

                while (N > 0)
                {
                    int digit = N % 10;
                    reversedN = reversedN * 10 + digit;
                    N = N / 10;
                }

                Console.WriteLine($"Число {originalN} справа налево: {reversedN}");
                Console.ReadKey();
            }
        }
    }

    //Esep 42
    using System;
    namespace Modul2
    {
        public class Program
        {
            static void Main()
            {
                Console.WriteLine("Таблица умножения на 9:");

                for (int i = 1; i <= 10; i++)
                {
                    int result = 9 * i;
                    Console.WriteLine($"9 * {i} = {result}");
                }
            }
        }
    }

    //Esep 41
    using System;
    namespace Modul2
    {
        public class Program
        {
            static void Main()
            {
                Console.WriteLine("Фунты\tКилограммы");

                for (int pounds = 1; pounds <= 10; pounds++)
                {
                    double kilograms = pounds * 453.0 / 1000.0;
                    Console.WriteLine($"{pounds}\t{kilograms:F3}");
                }
            }
        }
    }


    //Esep 40
    using System;
    namespace Modul2
    {
        public class Program
        {
            static void Main(string[] args)
            {
                // a. Все целые числа от 20 до 35
                Console.WriteLine("a. Все целые числа от 20 до 35:");
                for (int i = 20; i <= 35; i++)
                {
                    Console.WriteLine(i);
                }

                // b. Квадраты всех целых чисел от 10 до b
                Console.Write("b. Введите значение b (b > 10): ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Квадраты чисел от 10 до " + b + ":");
                for (int i = 10; i <= b; i++)
                {
                    Console.WriteLine(i * i);
                }
                // c. Третьи степени всех целых чисел от a до 50
                Console.Write("c. Введите значение a (a < 50): ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Третьи степени чисел от " + a + " до 50:");
                for (int i = a; i <= 50; i++)
                {
                    Console.WriteLine(Math.Pow(i, 3));
                }

                // d. Все целые числа от a до b
                Console.Write("d. Введите значение a: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Введите значение b (b > a): ");
                int end = int.Parse(Console.ReadLine());
                Console.WriteLine("Целые числа от " + start + " до " + end + ":");
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
        }
    }


    //Sep 36
    using System;
    namespace Modul2
    {
        public class Program
        {
            static void Main()
            {
                Console.Write("Введите порядковый номер месяца : ");
                int month = int.Parse(Console.ReadLine());

                string season;

                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        season = "Зима";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        season = "Весна";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        season = "Лето";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        season = "Осень";
                        break;
                    default:
                        season = "Неверный номер месяца";
                        break;
                }

                Console.WriteLine($"Месяц {month} относится к времени года: {season}");
            }
        }
    }


    //Esep 35
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                Console.Write("Введите порядковый номер месяца: ");
                int month = int.Parse(Console.ReadLine());

                string monthName;

                switch (month)
                {
                    case 1:
                        monthName = "январь";
                        break;
                    case 2:
                        monthName = "февраль";
                        break;
                    case 3:
                        monthName = "март";
                        break;
                    case 4:
                        monthName = "апрель";
                        break;
                    case 5:
                        monthName = "май";
                        break;
                    case 6:
                        monthName = "июнь";
                        break;
                    case 7:
                        monthName = "июль";
                        break;
                    case 8:
                        monthName = "август";
                        break;
                    case 9:
                        monthName = "сентябрь";
                        break;
                    case 10:
                        monthName = "октябрь";
                        break;
                    case 11:
                        monthName = "ноябрь";
                        break;
                    case 12:
                        monthName = "декабрь";
                        break;
                    default:
                        monthName = "Неверный номер месяца";
                        break;
                }

                Console.WriteLine($"Месяц с порядковым номером {month} - это {monthName}");
            }
        }
    }

    //Esep 34
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                Console.Write("Введите порядковый номер дня недели: ");
                int dayOfWeek = int.Parse(Console.ReadLine());

                string dayName;

                switch (dayOfWeek)
                {
                    case 1:
                        dayName = "понедельник";
                        break;
                    case 2:
                        dayName = "вторник";
                        break;
                    case 3:
                        dayName = "среда";
                        break;
                    case 4:
                        dayName = "четверг";
                        break;
                    case 5:
                        dayName = "пятница";
                        break;
                    case 6:
                        dayName = "суббота";
                        break;
                    case 7:
                        dayName = "воскресенье";
                        break;
                    default:
                        dayName = "Неверный номер дня недели";
                        break;
                }

                Console.WriteLine($"День недели с порядковым номером {dayOfWeek} - это {dayName}");
            }
        }

    }

    //Esep 33
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
        static void Main()
        {
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 10 || number > 99)
            {
                Console.WriteLine("Введенное число не является двузначным.");
            }
            else
            {
                int firstDigit = number / 10;  // Получаем первую цифру
                int secondDigit = number % 10; // Получаем вторую цифру

                Console.WriteLine($"Первая цифра: {firstDigit}");
                Console.WriteLine($"Вторая цифра: {secondDigit}");

                if (firstDigit > secondDigit)
                {
                    Console.WriteLine("Первая цифра больше второй.");
                }
                else if (firstDigit < secondDigit)
                {
                    Console.WriteLine("Вторая цифра больше первой.");
                }
                else
                {
                    Console.WriteLine("Цифры равны.");
                }
            }
        }
    }
    }

    //Esep 32
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            // Проверка на четность
            bool isEven = (number % 2 == 0);

            // Проверка на окончание на 7
            bool endsWith7 = (number % 10 == 7);

            if (isEven)
            {
                Console.WriteLine("Число является четным.");
            }
            else
            {
                Console.WriteLine("Число не является четным.");
            }

            if (endsWith7)
            {
                Console.WriteLine("Число оканчивается на 7.");
            }
            else
            {
                Console.WriteLine("Число не оканчивается на 7.");
            }
        }
    }
    }

    //Esep 31
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                double km = 10.0;
                double f = 3280.84;

                // Преобразование расстояния в футах в километры
                double km2 = f * 0.000305;

                if (km < km2)
                {
                    Console.WriteLine("Расстояние в километрах меньше.");
                }
                else if (km > km2)
                {
                    Console.WriteLine("Расстояние в футах меньше.");
                }
                else
                {
                    Console.WriteLine("Расстояния равны.");
                }
            }
        }
    }


    //Esep 30

    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                Console.Write("Введите первое вещественное число: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Введите второе вещественное число: ");
                double n2 = double.Parse(Console.ReadLine());

                if (n1 > n2)
                {
                    Console.WriteLine($"{n1} больше, чем {n2}.");
                }
                else if (n1 < n2)
                {
                    Console.WriteLine($"{n1} меньше, чем {n2}.");
                }
                else
                {
                    Console.WriteLine($"{n1} и {n2} равны.");
                }
            }
        }
    }

    //Esep 24
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                Console.Write("Введите значение a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Введите значение b: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Введите значение c: ");
                int c = int.Parse(Console.ReadLine());

                // обмен
                int temp = b;
                b = c;
                c = a;
                a = temp;

                Console.WriteLine($"После обмена: a = {a}, b = {b}, c = {c}");
            }
        }
    }

    //Esep 22
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                Console.Write("Введите первое целое число: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе целое число: ");
                int n2 = int.Parse(Console.ReadLine());

                // Среднее арифметическое
                double averageArithmetic = (double)(n1 + n2) / 2;

                // Среднее геометрическое 
                double averageGeometric = Math.Sqrt((double)(n1 * n2));

                Console.WriteLine($"Среднее арифметическое: {averageArithmetic}");
                Console.WriteLine($"Среднее геометрическое: {averageGeometric}");
            }
        }
    }


    //Esep 20
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                double R = 6350; // Радиус Земли в километрах
                double H= 100; // Высота над Землей в километрах

                // Расчет расстояния до линии горизонта
                double distanceToHorizon = Math.Sqrt(Math.Pow(R+ H, 2) - Math.Pow(R, 2));

                Console.WriteLine($"Расстояние до линии горизонта: {distanceToHorizon} км");
            }
        }
    }

    //esep 19
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                double R = 4.0;

                // Вычисление диаметра
                double D = 2 * R;

                Console.WriteLine($"Диаметр окружности с радиусом {R} равен {D}");
            }
        }
    }



    //esep 18
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main()
            {
                double L = 14.0; 

                // Вычисление периметра квадрата
                double P = 4 * L;

                Console.WriteLine($"Периметр квадрата со стороной {L} равен {P}");
            }
        }
    }


    //esep 16
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main(string[] args)
            {
                // Вид функция  y = ax^2 + bx + c
                double a = 7.0;
                double b = -3.0;
                double c = 6.0;

                Console.WriteLine("Введите значение x:");
                double x = double.Parse(Console.ReadLine());

                double y = a * x * x + b * x + c;
                Console.WriteLine($"Значение функции при x = {x}: y = {y}");

                Console.ReadKey();
            }
        }
    }

    //Esep 17
    using System;
    namespace Modul_2._1
    {
        public class Program
        {
            static void Main(string[] args)
            {
                // Вид функция  X = ya^2 + ba + c
                double y = 12.0;
                double b = 7.0;
                double c = -16.0;

                Console.WriteLine("Введите значение x:");
                double a = double.Parse(Console.ReadLine());

                double x = y * a * a + b * a + c;
                Console.WriteLine($"Значение функции при a = {a}: x = {x}");

                Console.ReadKey();
            }
        }
    }


    */

