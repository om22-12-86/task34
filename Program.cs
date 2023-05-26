// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// void RandomArr(int[] arr)
//  {
//     for (int i = 0; i < arr.Length; i++)
//     {
//      arr[i] = new Random().Next(100, 999);
//     }
//  }
// void PrintArray(int[] arr)
//  {
//     for (int i = 0; i < arr.Length; i++)
//     {
//      Console.Write($"{arr[i]} ");
//     }
//  }
// void CountEvenNumbers(int[] arr)
//  { 
//   int count = 0;
//   for (int i = 0; i < arr.Length; i = i + 2)
//   {
//     count = count + 1;
//   }
//   Console.WriteLine(count);
//  }
// int[] array = new int[7];
// RandomArr(array);
// PrintArray(array);
// Console.WriteLine();
// CountEvenNumbers(array);

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void RandomArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]} ");
    }
}
void SummaOddIndex(int[] arr)
{
 int summar = 0;   
for (int i = 0; i < arr.Length; i = i + 2)
 {
   summar = summar + arr[i]; 
 }
 Console.WriteLine(summar);
} 
int[] array = new int[4];
RandomArr(array);
PrintArray(array);
Console.WriteLine();
SummaOddIndex(array);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void RandomArr(int[] arr)
  {
     for (int i = 0; i < arr.Length; i++)
     {
      arr[i] = new Random().Next(100, 999);
     }
  }
 void PrintArray(int[] arr)
  {
     for (int i = 0; i < arr.Length; i++)
     {
      Console.Write($"{arr[i]} ");
     }
  }
int DifferenceMaxMin(int[] arr)
{
    int max = arr[0];
    var min = arr[0];
    for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min) 
             {
                min = arr[i];
             }    
            if (arr[i] > max) 
             {
                max = arr[i];
             }    
        }
        Console.WriteLine();
        return (max - min);    
}

int[] array = new int[4];
RandomArr(array);
PrintArray(array);   
Console.WriteLine(DifferenceMaxMin(array));
