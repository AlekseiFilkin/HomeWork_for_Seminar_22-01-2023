/*Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. 
Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )
[21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]*/

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(20, 25);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 20)
    {
        array[i] = 200;
        break;
    }
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();