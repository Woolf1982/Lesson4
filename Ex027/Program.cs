/*Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Enter some number N: ");
int SomeNumber = Convert.ToInt32(Console.ReadLine());
int SumNumber(int SomeNumber)
  {
    int counter = Convert.ToString(SomeNumber).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
      advance = SomeNumber - SomeNumber % 10;
      result = result + (SomeNumber - advance);
      SomeNumber = SomeNumber / 10;
    }
    return result;
  }  
int sumNumber = SumNumber(SomeNumber);
Console.WriteLine("The sum of the digits in a number: " + sumNumber);  
