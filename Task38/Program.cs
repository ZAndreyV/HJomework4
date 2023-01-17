/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] array = CreatArrayRndDouble(5, 0, 10);
PrintArray(array);
double subtractionFromTheMaxMin = SubtractionFromTheMaxMin(array);
Console.WriteLine(subtractionFromTheMaxMin);

double[] CreatArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("Subtraction from the max min [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("] -> ");
}


double SubtractionFromTheMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[1];
    double sub = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        else if (min > arr[i]) min = arr[i];
        sub = max - min;
    }
    return sub;
}