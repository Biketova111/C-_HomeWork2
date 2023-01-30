/*  Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

using System.Security.Cryptography.X509Certificates;

int GetNumber (string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int DayOfTheWeek = GetNumber("Введите номер дня недели: ");
if (DayOfTheWeek >= 1 && DayOfTheWeek < 6)
{
    Console.WriteLine("нет");
}
else
{
   if (DayOfTheWeek == 6 || DayOfTheWeek == 7)
   {
    Console.WriteLine("да");
   }
   else
   {
    Console.WriteLine("Нет такого дня недели");
   }
}