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
            if(test == "5")
            {
                //DateTime d;
                //string data = Convert.d.ToString("22.12.2021");
                //CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(d.DayOfWeek);
            }
        }
    }
}
