/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
//int max;
//int min;
int result;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]} ");
}
int max = array[0];
int min = array[0];
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
result = max - min;
Console.WriteLine($"Разница между {max} и {min} равна {result}");