// Задача 15:  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine(Readint("Введите число от 1 до 7: "));
string Readint(string message)
{
    Console.Write(message);
    string stroka = Console.ReadLine();
    if (int.TryParse(stroka, out int a))
    {
        if (a > 0 && a < 8)
        {
            if (a == 7 || a == 6)
            {
                Console.Write("Под цифрой " + a + " - Выходной ");
            }
            else
            {
                Console.Write("Под цифрой " + a + " - Рабочий ");
            }
        }
        else
        {
            Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить ");
        }
        return "день";
    }
    else
    {
        return ("Нужно ввести число");
    }
}

