//Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        int count = 0; 
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next(100,1000);
            if(array[i] % 2 == 0)
            {
                count = count + 1;
            }
        }
        Console.Write(count);        
    }
}

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0; 
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next();
            if(i % 2 != 0)
            {
                sum = sum + array[i];
            }
        }
        Console.Write(sum);        
    }
}


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массиваa
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[n];        
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next();
        }
        double max = array[0];
        double min = array[1];
        for (int i = 0; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine(max - min);        
    }
}