
using System;
using System.Linq;



class Switch
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве");
            Console.WriteLine("2.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");
            Console.WriteLine("3.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива");
            Console.Write("Выбери номер задания:");
            if (TryGetUserInput(out int value))
            {
                switch (value)
                {
                    case 1: Task34.Task34Main(); break;
                    case 2: Task36.Task36Main(); break;
                    case 3: Task38.Task38Main(); break;
                    default: Console.WriteLine("Извини, такой задачи нет :(. Попробуй еще раз!"); break;
                }
            }
        }
        
    }

    private static bool IsString(string input)
    {
        return !int.TryParse(input, out _);
    }

    private static bool TryGetUserInput(out int value)
    {
        string input = Console.ReadLine();
        if (IsString(input))
        {
            value = 0;
            return false;
        }

        else
        {
            value = int.Parse(input);
            return true;
        }
    }
}

class Task34
{
    public static void Task34Main()
    {
        Console.Write("Введите длину массива: ");
        CreateRandomArray(out int[] array);
        int count = 0;

        for (int x = 0; x < array.Length; x++)
        {
            if (array[x] % 2 == 0)
                count++;
        }
        Console.WriteLine($"Из {array.Length} чисел, {count} четных");

    }

    private static void CreateRandomArray(out int[] array)
    {
        int arraySize = int.Parse(Console.ReadLine());
        array = new int[arraySize];
        Random random = new Random();
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
            Console.Write(array[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();

    }

}

class Task36
{
    public static void Task36Main()
    {
        Console.Write("Введите длину массива: ");
        CreateRandomArray(out int[] array);
        SumOfOddNumbers(array);

    }

    private static void CreateRandomArray(out int[] array)
    {
        int arraySize = int.Parse(Console.ReadLine());
        array = new int[arraySize];
        Random random = new Random();
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 10);
            Console.Write(array[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();

    }

    private static void SumOfOddNumbers(int[] array)
    {
        int sum = 0;

        for (int x = 0; x < array.Length; x += 2)
        {
            sum += array[x];

        }
        Console.WriteLine($"В массиве {array.Length} чисел. Сумма элементов, cтоящих на нечётных позициях = {sum}");

    }
}


class Task38
{
    public static void Task38Main()
    {
        Console.WriteLine("Введите длину массива: ");
        CreateDoubleArray(out double[] array);
        Console.WriteLine("Разница между максимальным и минимальным числом = {0:F2}", ComparisonMaxAndMin(array));
    }

    private static void CreateDoubleArray(out double[] array)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        array = new double[input];
        Random rand = new Random();
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 10) + rand.NextDouble();
            Console.Write("{0:F2} ", array[i]);
        }
        Console.Write("]");
        Console.WriteLine();
    }

    private static double ComparisonMaxAndMin(double[] array)
    {
        double MaxValue = array.Max();
        double MinValue = array.Min();
        return MaxValue - MinValue;
    }
}
