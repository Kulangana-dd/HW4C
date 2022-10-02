/*Задача 29: Напишите программу, в которой пользователь задает длину массива,
 элементы которого задаются в диапазоне [1,99] и выводит на экран.
    5 -> [1, 2, 5, 7, 19]
    3 -> [6, 1, 33]*/
    
void FillArray (int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] finalArray)
{
    int count = finalArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(finalArray[position]);
        Console.Write(" ");
        position++;
    }
}

Console.Write("Задайте длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

FillArray (array);
PrintArray (array);