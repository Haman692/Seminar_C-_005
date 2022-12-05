 // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Next(-9, 10)  [-9; 10)
// Найдите сумму отрицательных и положительных элементов массива.

const int SIZE = 12;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] array = new int[SIZE];


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for( int i = 0 ; i<size; i++)
    { 
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    return arr;
}

void SumPositiveAndNegative(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i] > 0)
        {
           sumP+=arr[i]; // sumP = sumP + array[i] // INDEX = INDEX + 1 // INDEX++ // INDEX +=array[i] 
        }
        else
        {
            sumN+=arr[i];
        }   
    }
}

array = FillArrayWithRandomNumbers(12, -9, 9);
Console.WriteLine('[' + string.Join(", ", array) + ']');
SumPositiveAndNegative(array, out int sumP, out int sumN);

Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных = {sumN}");