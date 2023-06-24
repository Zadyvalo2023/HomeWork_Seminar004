// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


using System;// Это директива using, которая позволяет использовать функционал из пространстваимен System
namespace PowerExample //это определение пространства имен PowerExample, в котором содержится класс Program;
{
    class Program // class Program - это определение класса Program, который содержит точку входа в программу - метод Main
    {

        //это метод Main, который запускается при запуске программы
        //Он принимает массив строк в качестве аргументов и имеет модификаторы static и void, что означает, что он является статическим методом, который не возвращает никакого значения;
static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите степень B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            Console.WriteLine($"{a} в степени {b} = {result}");
            Console.ReadKey();
        }
    }
}