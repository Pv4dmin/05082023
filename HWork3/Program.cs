// программа которая на вход принимает число и выдаёт, является ли оно четным или нет
Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());
int res = Num % 2;
 if (res != 0)
    {
        Console.WriteLine("Число является нечетным");
    }
else 
{
    Console.WriteLine("Число является четным");
}
