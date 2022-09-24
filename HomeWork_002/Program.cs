void Zadania1()
{
    Console.WriteLine("Введите трехзначное число ");
    int a = int.Parse(Console.ReadLine());
    int result = ((a / 10) % 10);
    Console.Write(result);
}

void Zadania2()
{
    Console.WriteLine("Введите число ");
    int a = int.Parse(Console.ReadLine());
    if (a < 99)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        Console.Write(a.ToString()[2]);
    }

}

void Zadania3 ()
{
    Console.WriteLine("Введите цифру обозначающюю день недели от 1 до 7 ");
    int a = int.Parse(Console.ReadLine());
    if (a < 6)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        Console.Write("День выходной");
    }
}
Zadania2();