/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int count = 0;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    count++;
}
Console.Write($"Количество четных чисел в массиве = {count}");