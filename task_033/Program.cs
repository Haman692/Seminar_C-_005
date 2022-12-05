// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


Console.Clear();
const int SIZE = 4;
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

bool FindNumber(int[] arr, int number)
{
    bool flag = false;
    for (int i = 0; i < SIZE; i++)
    {
        if (arr[i] == number)
        {
            flag = true;      
            break;
        }
    }
    return flag;
}
System.Console.WriteLine("Введите число");
int findNumber = Convert.ToInt32(Console.ReadLine());

array = FillArrayWithRandomNumbers(SIZE, -1, 1);
Console.Write('[' + string.Join(", ", array) + ']');
bool flag = FindNumber(array, findNumber);
if (flag)
{
    System.Console.WriteLine(" Число присутсвует");
}
else
{
    System.Console.WriteLine(" Число  не присутсвует");
}