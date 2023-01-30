/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


int GetNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = GetNumber("Введите трехзначное число: ");
int secondDigit = number/10 - (number/100*10);
Console.WriteLine(secondDigit);