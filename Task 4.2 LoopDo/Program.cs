using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._2_LoopDo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определение наибольшего количества положительных либо отрицательных целых чисел в введенной последовательности
            Console.WriteLine("Введите положительные и отрицательные целые числа в произвольной последовательности");
            Console.WriteLine("Для завершения последовательности введите 0");
            int number, negativeNumber = 0, positiveNumber = 0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    negativeNumber++;
                }
                else if (number>0)
                {
                    positiveNumber++;
                }
            } while (number != 0);

            Console.WriteLine("Введено {0} положительных и {1} отрицательных чисел.",positiveNumber,negativeNumber);
            if (negativeNumber!=positiveNumber)
            {
                Console.WriteLine(negativeNumber > positiveNumber ? "Количество отрицательных чисел больше, чем положительных" : "Количество положительных чисел больше, чем отрицательных");
            }
            else
            {
                Console.WriteLine("Количество отрицательных и положительных чисел одинаково.");
            }
            
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
