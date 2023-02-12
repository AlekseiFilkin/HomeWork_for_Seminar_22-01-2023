/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int sum = 0;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 1; i < array.Length; i+=2)
{
    sum +=array[i];
    
}
Console.WriteLine($"Сумма элементов на нечетных позициях в массиве = {sum}");