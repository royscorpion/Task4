using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод квадрата введенного целого числа, вычисленного по формуле N^2 = 1 + 3 + 5 + ... + (2*N-1).
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for (int i = 1; i <= (2 * number - 1); i += 2)
            {
                Sum += i;
                Console.WriteLine("Текущее значение суммы = {0}", Sum);
            }
            Console.WriteLine("Квадрат введенного числа {0} равен {1}",number,Sum);
            
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
