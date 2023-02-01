using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите задание, которое хотите проверить: ");
            string test = Console.ReadLine();

            if (test == "1")
            {
                Console.Write("Введите число от 1 до 100: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0 && num % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            if (test == "2")
            {
                int answer;
                Console.Write("Введите значение: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите процент: ");
                int persent = Convert.ToInt32(Console.ReadLine());

                answer = (num * persent) / 100;
                Console.WriteLine("Ответ: {0}", answer);
            }
            if (test == "3")
            {
                int size = 4;
                string numbers = "";
                Console.WriteLine("Введите четыре числа: ");
                string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < (size < str.Length ? size : str.Length); ++i)
                    numbers += str[i];
                Console.Write("Число: {0}\n", numbers);
            }
            if (test == "4")
            {

                int size = 6;
                int[] numbers = new int[size];
                int firstnum = 0;
                Console.WriteLine("Введите шестизначное число: ");
                string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < (size < str.Length ? size : str.Length); ++i)
                    firstnum = Convert.ToInt32(str[i]);

                for (int i = size - 1; i >= 0; i--)
                {
                    numbers[i] = firstnum % 10;
                    firstnum /= 10;
                }

                if (numbers.Length != 6)
                {
                    Console.WriteLine("Ошибка ввода");
                    return;
                }

                Console.Write("Введите первый разряд: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второй разряд: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                int rezerv = numbers[num - 1];
                numbers[num - 1] = numbers[num1 - 1];
                numbers[num1 - 1] = rezerv;

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("{0}\n", numbers[i]);
                }
            }
            if (test == "5")
            {
                Console.WriteLine("Введите дату: ");
                string date = Console.ReadLine();
                int day = Convert.ToInt32(date.Substring(0, 2));
                int month = Convert.ToInt32(date.Substring(3, 2));
                int year = Convert.ToInt32(date.Substring(6, 4));
                string season;
                if (month <= 2 || month == 12)
                {
                    season = "Winter";
                }
                else if (month <= 5 || month >= 3)
                {
                    season = "Spring";
                }
                else if (month <= 8 || month >= 6)
                {
                    season = "Summer";
                }
                else
                {
                    season = "Autumn";
                }
                int dayWeek = day % 7;
                string dayName = "";
                switch (dayWeek)
                {
                    case 0:
                        dayName = "Monday";
                        break;
                    case 1:
                        dayName = "Tuesday";
                        break;
                    case 2:
                        dayName = "Wednesday";
                        break;
                    case 3:
                        dayName = "Thursday";
                        break;
                    case 4:
                        dayName = "Friday";
                        break;
                    case 5:
                        dayName = "Saturday";
                        break;
                    case 6:
                        dayName = "Sunday";
                        break;
                }
                Console.WriteLine("Результат: {0} {1} {2} {3}", season, year, dayName, day);
                Console.ReadKey();
            }
            if (test == "6")
            {
                Console.WriteLine("Введите температуру в \n1.Цельсиях \n2.Фаренгейтах");
                double num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите температуру: ");
                double tempe = Convert.ToInt32(Console.ReadLine());

                double res = 0;
                if (num == 1)
                {
                    res = (tempe * (1.8)) + 32;
                    Console.WriteLine($"Температура в Цельсиях {tempe} - температура в Фаренгейтах {res} ");
                }
                else if (num == 2)
                {
                    res = (tempe - 32) * 0.55555556;
                    Console.WriteLine($"Температура в Фаренгейтах {tempe} - температура в Цельсиях {res} ");
                }
                else
                {
                    Console.WriteLine("Ошибка вы ввели некорректное значение");
                }
            }
            if (test == "7")
            {
                Console.Write("Введите диапазон от: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("И до: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int even = 0;

                if (num1 > num2)
                {
                    for (int i = num2; i < num1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            even++;
                        }
                    }
                }
                else if (num2 >= num1)
                {
                    for (int i = num2; i < num1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            even++;
                        }
                    }
                }

                Console.WriteLine($"Количество четных чисел {even}");
            }
        }
    }
}
