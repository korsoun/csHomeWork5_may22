// Задача 38.
// Задать массив вещественных чисел и найти разницу между максимальным и минимальным элементом.

double[] FillArray(double[] newArray)
{
    Random previousValues = new Random();
    for (int i = 0; i < (newArray.GetLength(0)); i++)
    {
        double floatValue = previousValues.NextDouble() * 10;               // в материалах написано, что вывести дробные числа напрямую можно только от 0 до 1
        string formatingFloatVal = string.Format("{0:f2}", floatValue);     // для получения большего числа результат генерации умножается на 10 и округляется до 2-х цифр через перевод в строку
        newArray[i] = Convert.ToDouble(formatingFloatVal);                  // для записи в массив строки переводятся обратно в Double
    }
    return newArray;
}

double[] ArrayOutput(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < (array.GetLength(0)) - 1; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine(array[(array.GetLength(0)) - 1] + "]");
    return array;
}

string GetMaxMinDifference(double[] array)
{
    double maxValue = array[0];
    double minValue = array[0];
    for (int i = 1; i < (array.GetLength(0)); i = i + 1)       
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
        else
        {
            if (array[i] < minValue) { minValue = array[i];}               // в виде подусловия, чтобы не проверять число, ставшее максимальным,  
        }
    }
    double difference = maxValue - minValue;
    string result = string.Format("{0:f2}", difference);
    return result;
}

Console.Write("Задайте длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
double[] newArray = new double[arrayLength];

FillArray(newArray);
Console.Write("Задан массив ");
ArrayOutput(newArray);
Console.WriteLine($"Разница максимального и минимального элемента {GetMaxMinDifference(newArray)}");
