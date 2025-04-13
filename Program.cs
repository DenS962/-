using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ср
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Артамонов Денис 1 варiант");
            Console.WriteLine("Введiть чотирицифрове число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Це не чотирицифрове число!");
                return;
            }

            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;

            int result = secondDigit * 10 + thirdDigit;

            Console.WriteLine("Нове двозначне число: " + result);
        }
    }
}
