// Задача 37, найти решение лучше.
// Найти произведение пар чисел в одномерном массиве и вывести в виде нового массива.

int[] FillArray(int[] array)                            // метод для заполнения массива случайными числами
{
    Random arrayValues = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = arrayValues.Next(-9, 10);
    }
    return array;
}

void ArrayOutput(int[] array)                            // метод для вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.GetLength(0) - 1]);
    Console.WriteLine("]");
}

Console.Write("Задайте длину массива: ");
int firstArrayLength = Convert.ToInt32(Console.ReadLine());                 // определение длины массива исходных данных
int[] firstArray = new int[firstArrayLength];                               // создание этого массива

FillArray(firstArray);
Console.Write("Сгенерирован массив ");
ArrayOutput(firstArray);
Console.WriteLine();

int[] GetMultipliedArray(int[] firstArray)                                     // метод для получения массива с перемноженными числами
{
    int secondArrayLength = ((firstArray.GetLength(0)) / 2) + ((firstArray.GetLength(0)) % 2);    // определение длины целевого массива
    int[] secondArray = new int[secondArrayLength];                                               // создание целевого массива
    int i = 0;                                                                                    // два индекса для прохода по исходному массиву
    int j = ((firstArray.GetLength(0)) - 1);
    while (i < (secondArray.GetLength(0)))
    {
        if (i == j)                                         // при нечетной длине массива центральное число входит в целевой массив без умножения на что-либо
        {
            secondArray[i] = firstArray[i];
        }
        else                                                // пока индексы не совпадают, массив заполняется по обычным правилам
        {
            secondArray[i] = firstArray[i] * firstArray[j];
        }
        i++;
        j--;
    }
        return secondArray;               
}

Console.Write("Массив из перемноженных элементов: ");
ArrayOutput(GetMultipliedArray(firstArray));
