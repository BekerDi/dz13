using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;


namespace dz13
{
    internal class Program
    {
        static async Task Main(string[] args)
        {   
             MyThread thread1 = new MyThread("Поток 1");
        Thread t1 = new Thread(new ThreadStart(thread1.PrintNumbers));
        t1.Start();

        MyThread thread2 = new MyThread("Поток 2");
        Thread t2 = new Thread(new ThreadStart(thread2.PrintNumbers));
        t2.Start();

        MyThread thread3 = new MyThread("Поток 3");
        Thread t3 = new Thread(new ThreadStart(thread3.PrintNumbers));
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
            //Задание 2
            Calculator calculator = new Calculator();

            Console.Write("Введите число для вычисления факториала и квадрата: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Введите корректное целое число.");
                return;
            }

            // Вычисление квадрата числа синхронно
            int square = calculator.CalculateSquare(number);
            Console.WriteLine($"Квадрат числа {number} равен {square}");

            // Вычисление факториала асинхронно
            BigInteger factorial = await calculator.CalculateFactorialAsync(number);
            Console.WriteLine($"Факториал числа {number} равен {factorial}");

            Console.ReadKey();

            

        }
    }
}
       
