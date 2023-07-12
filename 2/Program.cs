//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int GetInfo ()
{
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}
void FindDistance()
{
Console.Write("Введите 1 координату точки A: ");
int a1 = GetInfo();
Console.Write("Введите 2 координату точки A: ");
int a2 = GetInfo();
Console.Write("Введите 3 координату точки A: ");
int a3 = GetInfo();
Console.Write("Введите 1 координату точки B: ");
int b1 = GetInfo();
Console.Write("Введите 2 координату точки B: ");
int b2 = GetInfo();
Console.Write("Введите 3 координату точки B: ");
int b3 = GetInfo();

double result = Math.Round(Math.Sqrt(
    Math.Pow(b1 - a1, 2) + 
    Math.Pow(b2 - a2, 2) + 
    Math.Pow(b3 - a3, 2)
), 2);

Console.WriteLine($"A ({a1}, {a2}, {a3}); B ({b1}, {b2}, {b3}) -> {result}");
}
FindDistance();