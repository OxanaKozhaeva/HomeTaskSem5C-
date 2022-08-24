/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

class Program
{
    static void FillArray(int[]array)
    {
        int length=array.Length;
        for (int i = 0; i < length; i++)
        {
            array[i]=new Random().Next(0,100);
        }
    }
    static void WriteArray(int[] array)
    {
        Console.WriteLine("Вывод массива");
        for (int i=0;i<array.Length;i++)
        {
        Console.Write(array[i]+" ");
        }
        Console.WriteLine(" ");
    }static int MaxNumberArray(int[] array)
    {
        int max=0;
        for (int i = 0; i < array.Length; i++)
        {
           if(array[i]>max) 
           {
            max=array[i];
           }
        }
        return max;
    }
    static int MinNumberArray(int[] array)
    {
        int min=array[0];
        for (int i = 0; i < array.Length; i++)
        {
           if(array[i]<min) 
           {
            min=array[i];
           }
        }
        return min;
    }
    static void Main(string[]args)
    {
        int[] array=new int[10];
        FillArray(array);
        WriteArray(array);
        int max=MaxNumberArray(array);
        int min=MinNumberArray(array);
        Console.WriteLine("Максимальное значение - "+max);
        Console.WriteLine("Минимальное значение - "+min);
        Console.WriteLine("Разница - "+ (max-min));
    }
}
