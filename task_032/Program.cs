// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



Console.Clear();
const int SIZE = 4;
int [] array = new int[SIZE];

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

array = FillArrayWithRandomNumbers(SIZE, -9, 9);
Console.Write('[' + string.Join(", ", array) + ']');

for (int i = 0; i < SIZE; i++)
{
    array[i] *= -1;
}
Console.Write(" > ");
Console.Write('[' + string.Join(", ", array) + ']');