//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int GetInfo ()
{
    Console.Write("Введите число: ");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}

void ResultWhile (int number)
{
int i = 1; 
double result;
Console.Write($"{number} -> ");
while (i < number)
{
    Console.Write($"{result = Math.Pow(i, 3)}, ");
    i++;
}
Console.WriteLine (result = Math.Pow(number, 3));
}

void ResultFor (int number)
{
double result;
Console.Write($"{number} -> ");
for (int i = 1; i < number; i++)
{
    Console.Write($"{result = Math.Pow(i, 3)}, ");
}
Console.WriteLine (result = Math.Pow(number, 3));
}

int number = GetInfo();

ResultWhile(number);
ResultFor(number);