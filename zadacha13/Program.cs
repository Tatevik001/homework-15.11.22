// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string ThirdDigit(int number)
{
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        return (number % 10).ToString();
    }
    else
    {
        return " Третьей цифры нет ";
    }
}
Console.WriteLine(ThirdDigit(456));