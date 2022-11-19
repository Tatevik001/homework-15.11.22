// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
while (true)
{
    string input = Console.ReadLine();
    if (input.Equals("exit"))
    {
        break;
    }
    else
    {
        if (int.TryParse(input, out int number) && (number <= 999) && (number >= 100))
        {
            Console.WriteLine("{0}->{1}", input, input[1]);
        }
        else
        {
            Console.WriteLine("Вы ввели не трехзначное число");
        }
    }
}
