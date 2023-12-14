using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz13
{
    class Calculator
    {
        // Синхронный метод для вычисления квадрата числа
        public int CalculateSquare(int number)
        {
            return number * number;
        }

        // Асинхронный метод для вычисления факториала
        public async Task<BigInteger> CalculateFactorialAsync(int number)
        {
            return await Task.Run(() =>
            {
                BigInteger result = 1;

                // Если число отрицательное, факториал не определен
                if (number < 0)
                    throw new ArgumentException("Число должно быть неотрицательным.");

                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                    // Задержка потока на 8 секунд (для всей операции, а не каждой итерации)
                    if (i == 1)
                        Thread.Sleep(8000);
                }

                return result;
            }
            );

        }
    }
    
