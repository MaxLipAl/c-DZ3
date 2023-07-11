//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int GetInfo ()
{
    Console.Write("Введите число: ");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}

void Result(int number)
{
    if (number < 10000 || number > 99999)
    {
        Console.WriteLine($"Вы ввели число {number}, которое не пятизначное.");
    }
    else 
    {
        if (number % 10 == number / 10000 && (number / 10) % 10 == (number / 1000) % 10) 
        {
            Console.WriteLine ($"{number} -> Да");
        }
        else
        {
            Console.WriteLine ($"{number} -> Нет");
        }
    }
}

Result(GetInfo());




