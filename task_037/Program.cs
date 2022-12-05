// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();
const int SIZE = 6;
int[] array = new int[SIZE];

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    return arr;
}

int[] Mult(int[] arr)
{
    int size = arr.Length;
    int[] multyArr = new int[size/2 +size%2];
    for (int i = 0; i < size/2; i++)
    {
        int lenght = size - 1;
        multyArr[i] = arr[i] * arr[lenght - i];
    }
    if(size%2 == 1) 
    {
        multyArr[size/2] = arr[size/2];
    }
    return multyArr;

}

array = FillArrayWithRandomNumbers(SIZE, -10, 10);
Console.Write('[' + string.Join(", ", array) + ']');

int[] newArray = Mult(array);
Console.Write('[' + string.Join(", ", newArray) + ']');
