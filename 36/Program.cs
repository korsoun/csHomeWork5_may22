// Задача 36
// Задать одномерный массив из случайных чисел и найти сумму элементов на нечетных позициях.

int[] FillArray (int[] newArray)
{
    for(int i = 0; i < (newArray.GetLength(0)); i++)
    {
        newArray[i] = new Random().Next(1, 100);
    }
    return newArray;
}

int[] ArrayOutput (int[] array)
{
    Console.Write("[");
    for(int i = 0; i < (array.GetLength(0)) - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[(array.GetLength(0)) - 1] + "]");
    return array;
}

int GetSummOfOddPositions (int[] array)
{
    int summ = 0;
    for(int i = 1; i < array.GetLength(0); i = i + 2)     // посчитаем, что нечетные позиции - это позиции с нечетным индексом
    {                                                     // если взять за нечетные позиции те, которые фактически нечетные, то цикл начнется с i=0
summ = summ + array[i];
    }
    return summ;
}

Console.Write("Задайте длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[arrayLength];

FillArray(newArray);
Console.Write("Задан массив ");
ArrayOutput(newArray);
Console.Write($"Сумма чисел на нечетных позициях равна {GetSummOfOddPositions(newArray)}");


