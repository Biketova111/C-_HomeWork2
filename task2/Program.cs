/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


int GetNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = GetNumber("Введите число: ");
    if (number/100 > 0)
    {
        while (number >= 999)
        {
            number = number/10;
        }
        int result = number%10;
        Console.WriteLine(result);
    }   
    else
    {
        Console.WriteLine("третьей цифры нет");
    }