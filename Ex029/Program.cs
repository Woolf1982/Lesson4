/* Задача 29:
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] GetRange( int Length)
{
    int [] array = new int [Length];
    Random rd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(0, 50);
    }
    return array;
}

void PrintArray( int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int [] array = GetRange(8);
PrintArray(array);