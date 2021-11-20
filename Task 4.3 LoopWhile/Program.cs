using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._3_LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нахождение максимально возможного количества квадратов, размещенных внутри прямоугольника
            #region Ввод исходных данных
            double sideA, sideB, sideC;
            Console.WriteLine("Введите длины двух сторон прямоугольника (A, B) и стороны квадрата (C).");
            Console.Write("Сторона прямоугольника A: ");
            while ((sideA = Convert.ToDouble(Console.ReadLine()))<=0)
            {
                Console.Write("Длина стороны не может быть отрицательной или равной нулю.\nВведите введите корректную длину: ");
            }
            Console.Write("Сторона прямоугольника B: ");
            while ((sideB = Convert.ToDouble(Console.ReadLine())) <= 0)
            {
                Console.Write("Длина стороны не может быть отрицательной или равной нулю. \nВведите введите корректную длину: ");
            }
            Console.Write("Сторона квадрата C: ");
            while ((sideC = Convert.ToDouble(Console.ReadLine())) <= 0)
            {
                Console.Write("Длина стороны не может быть отрицательной или равной нулю. \nВведите введите корректную длину: ");
            }
            #endregion

            int squareQty = 0;
            if (sideA > sideC && sideB > sideC)
            {
                double tempA = sideA;
                while (tempA >= sideC)
                {
                    double tempB = sideB;
                    while (tempB >= sideC)
                    {
                        squareQty++;
                        tempB -= sideC;
                    }
                    tempA -= sideC;
                }
            }
            else
            {
                Console.WriteLine("Квадрат не поместится внутри прямоугольника.");
            }

            Console.WriteLine("Максимальное количество квадратов, которые можно разместить внутри контура прямоугольника - {0}", squareQty);


            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
