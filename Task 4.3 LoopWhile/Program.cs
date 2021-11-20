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
            while ((sideA = Convert.ToDouble(Console.ReadLine())) <= 0)
            {
                Console.Write("Длина стороны не может быть отрицательной или равной нулю.\nВведите корректную длину: ");
            }
            Console.Write("Сторона прямоугольника B: ");
            while ((sideB = Convert.ToDouble(Console.ReadLine())) <= 0)
            {
                Console.Write("Длина стороны не может быть отрицательной или равной нулю. \nВведите корректную длину: ");
            }
            Console.Write("Сторона квадрата C: ");
            while ((sideC = Convert.ToDouble(Console.ReadLine())) <= 0)
            {
                Console.Write("Длина стороны не может быть отрицательной или равной нулю. \nВведите корректную длину: ");
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

            Console.WriteLine("Внутри контура прямоугольника со сторонами {1}x{2} можно разместить {0} квадратов со стороной {3}", squareQty, sideA, sideB, sideC);


            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
