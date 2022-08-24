/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

class Program
{
    static void FillArray(int[]array)
    {
        int length=array.Length;
        for (int i = 0; i < length; i++)
        {
            array[i]=new Random().Next(0,20);
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
    static int Sum(int[] array)
    {
        int sum=0;
        for (int i = 0; i < array.Length; i++)
        {
         if(i%2==1)
         {
            sum+=array[i];
         }  
        }
        Console.WriteLine("Сумма элементов, стоящих на нечётных позициях - "+sum);
        return sum;
    }
    static void Main(string[]args)
    {
        int[] array=new int[10];
        FillArray(array);
        WriteArray(array);
        Sum(array);
    }
}

