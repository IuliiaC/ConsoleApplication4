using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число от 0 до 100 ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 100 || num < 0)
            {
                Console.WriteLine("Но-но! Это число лежит за пределами границы");
            }

            else if (isSpecalNumber(num))
            {
                Console.WriteLine("Ты попал в спец число" + num + "!");
            }
            else if (isEvenNumber(num))

            {
                Console.WriteLine("Это парное число");
             }

            else
            {
                Console.WriteLine("Какой вы молодец! Вы попали в допустимые границы");
            }

            Console.ReadLine();

        }
        static bool isSpecalNumber(int numa)
        {
        numa = 0;
        switch (numa)
                {
                case 11:
                case 22:
                case 67:
                    return true;
                default:
                    return false;
            }
            }
        static bool isEvenNumber(int numb)
                {
            return (numb % 2) == 0 ? true : false; 

            }
    }
}
