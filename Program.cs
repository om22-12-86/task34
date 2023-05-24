// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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
void CountEvenNumbers(int[] arr)
 { 
  int count = 0;
  for (int i = 0; i < arr.Length; i = i + 2)
  {
    count = count + 1;
  }
  Console.WriteLine(count);
 }
int[] array = new int[7];
RandomArr(array);
PrintArray(array);
Console.WriteLine();
CountEvenNumbers(array);