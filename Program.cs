using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1.
            Написать программу, которая считывает символы с кла-виатуры, пока не будет введена точка. Программа должна 
            сосчитать количество введенных пользователем пробелов.*/
            //int counter_prob = 0;
            //char input = '0';
            //while (input != '.')
            //{
            //    input = Console.ReadKey().KeyChar;
            //    if (input == ' ')
            //    {
            //        counter_prob++;
            //    }
            //}
            //Console.WriteLine($"\nYou have entered: {counter_prob} probelov!");

            /*Задание 2.
            Ввести с клавиатуры номер трамвайного билета (6-значное 
            число) и про-верить является ли данный билет счастливым 
            (если на билете напечатано шестизначное число, и сумма 
            первых трёх цифр равна сумме последних трёх, то этот 
            билет считается счастливым).*/
            //void foo ()
            //{
            //    int number;
            //    number = Convert.ToInt32(Console.ReadLine());
            //    if ((number % 10 + (number / 10) % 10 + (number / 100) % 10) == ((number / 1000) % 10 + (number / 10000) % 10 + (number / 100000) % 10))
            //    {
            //        Console.WriteLine("CONGRAT - LUCKY TICKET !!!");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try another ticket...");
            //        foo();
            //    }
            //}
            //Console.WriteLine("Please, enter ticket number!");
            //foo();


            /*Задание 3.
            Числовые значения символов нижнего регистра в коде ASCII 
            отличаются от значений символов верхнего регистра на 
            величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует 
            все символы нижнего регистра в символы верхнего регистра и наоборот.*/
            //int symbl;
            //char input = '0';
            //endless_foo();
            //void endless_foo()
            //{
            //    input = Console.ReadKey().KeyChar;
            //    symbl = (int)input;
            //    //Console.WriteLine($"\nASCII code: {symbl}");
            //    if ((symbl <= 90) && (symbl >= 65)) //то это верхний регистр и надо конвертировать в нижний 
            //    {
            //        symbl += 32;
            //    }
            //    else if ((symbl <= 122) && (symbl >= 97)) //то это нижний регистр и надо конвертировать в верхний
            //    {
            //        symbl -= 32;
            //    }
            //    Console.Write((char)symbl);
            //    endless_foo();
            //}

            /*Задание 4.
            Даны целые положительные числа A и B (A < B). Вывести 
            все целые числа от A до B включительно; каждое число 
            должно выводиться на новой строке; при этом каждое 
            число должно выводиться количество раз, равное его 
            значению.*/
            //int A, B;
            //A = Convert.ToInt32(Console.ReadLine());
            //B = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine(A);
            ////Console.WriteLine(B);
            //for (int i = A; i <= B; i++ )
            //{
            //    for (int y = 0; y < i; y++)
            //    {
            //        Console.Write(i);
            //        Console.Write(' ');
            //    }
            //    Console.WriteLine("\n");
            //}


            /*Задание 5.
            Дано целое число N (> 0), найти число, полученное при 
            прочтении числа N справа налево. Например, если было 
            введено число 345, то программа должна вывести число 543.*/
            //int A, tmp;
            //A = Convert.ToInt32(Console.ReadLine());
            //tmp = A;
            ////Посчитаем кол-во цыфер числа
            //int razr = 1;
            //while ((tmp / 10) != 0)
            //{
            //    razr++;
            //    tmp /= 10;
            //}
            //int newA = 0;

            //for (int i = 0; i < razr; i++)
            //{
            //    //Console.WriteLine((int)(A / (Math.Pow(10,razr - 1 - i))) % 10);
            //    newA += ((int)(A / (Math.Pow(10, razr - 1 - i))) % 10) * (int)(Math.Pow(10, i));
            //}

            //Console.WriteLine(newA);


            Console.ReadKey();
        }
    }
}
