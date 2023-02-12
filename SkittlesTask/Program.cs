/*Кегли
N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. 
Затем по этому ряду бросили K шаров, при этом i-й шар сбил все кегли с номерами от li до ri включительно. 
Определите, какие кегли остались стоять на месте.
Программа получает на вход количество кеглей N и количество бросков K. Далее идет K пар чисел li, ri, при этом 1≤ li≤ ri≤ N.

Программа должна вывести последовательность из N символов, где j-й символ есть “I”, если j-я кегля осталась стоять, или “.”, если j-я кегля была сбита.*/
void PrintArr(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}
Console.Write("Введите число N, которое обозначает кол-во кеглей, которые выставили в один ряд: ");
int N = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число K, которое обозначает кол-во брошенных шаров: ");
int K = int.Parse(Console.ReadLine() ?? "");
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = i + 1;
}
int li = 0;
int ri = 0;
PrintArr(array);
for (int i = 0; i < K; i++)
{
    li = new Random().Next(1, N + 1);
    ri = new Random().Next(1, N + 1);
    if (li > ri)
    {
        int temp = li;
        li = ri;
        ri = temp;
    }
    Console.WriteLine($"li = {li}; ri = {ri}");
    for (int k = li - 1; k <= ri - 1; k++)
    {
        array[k] = 0;
    }
    PrintArr(array);
}
//PrintArr(array);
for (int j = 0; j < N; j++)
{
    if (array[j] == 0)
    {
        Console.Write(".");
    }
    if (array[j] != 0)
    {
        Console.Write("I");
    }
}