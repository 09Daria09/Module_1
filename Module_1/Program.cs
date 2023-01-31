using System;
using System.Collections.Generic;
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
                if(num % 2 == 0 && num % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if(num%2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(num%3 == 0)
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
                Console.WriteLine("Ответ: {0}",answer);
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
        }
    }
}
