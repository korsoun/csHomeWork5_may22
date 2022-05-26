// Задача 34.
// Задать массив из случайных трехзначных чисел и показать количество четных чисел


int[] Fill3DigitsArray (int[] newArray, int arrayLenght)
{
    Random ArrayValues = new Random();
    for(int i = 0; i < arrayLenght; i++)
    {
        newArray[i] = ArrayValues.Next(100, 1000);
    }
    return newArray;
}

int[] ArrayOutput (int[] array, int arrayLenght)
{
    Console.Write("[");
    for(int i = 0; i < arrayLenght - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[arrayLenght - 1] + "]");
    return array;
}

int EvenNumberCounter (int[] array, int arrayLenght)
{
    int count = 0;
    for(int i = 0; i < arrayLenght; i++)
    {
        if(array[i] % 2 == 0) {count++;}
    }
    return count;
}

Console.Write("Задайте длину массива: ");
int arrLenght = Convert.ToInt32(Console.ReadLine());

int[] newEmptyArray = new int[arrLenght];

Console.Write($"Создан массив: ");
Fill3DigitsArray(newEmptyArray, arrLenght);
ArrayOutput(newEmptyArray, arrLenght);
Console.WriteLine($"В этом массиве {EvenNumberCounter(newEmptyArray, arrLenght)} четных элементов.");