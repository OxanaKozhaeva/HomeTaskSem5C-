/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/
class Program
{
    static void FillArray(int[]array)
    {
        int length=array.Length;
        for (int i = 0; i < length; i++)
        {
            array[i]=new Random().Next(100,999);
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
    }
    static int CountEvenNumbers(int[] array)
    {
        int count=0;
        for (int i = 0; i < array.Length; i++)
        {
         if(array[i]%2==0)
         {
            count+=1;
         }  
        }
        Console.WriteLine("Количество чётных чисел в массиве - "+count);
        return count;
    }
    static void Main(string[]args)
    {
        int[] array=new int[10];
        FillArray(array);
        WriteArray(array);
        CountEvenNumbers(array);
    }
}
