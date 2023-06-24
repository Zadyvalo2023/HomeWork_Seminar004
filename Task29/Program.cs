// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]





class Program
{
    static void Main(string[] args)
    {
        // Задаем массив из 8 элементов
        int[] array = new int[8];
        Random rand = new Random();

        // Инициализируем массив случайными значениями
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(100);
        }

        // Выводим элементы массива на экран
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        // Ждем, пока пользователь не нажмет клавишу Enter
        Console.ReadLine();
    }
}