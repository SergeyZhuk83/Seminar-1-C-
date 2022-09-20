Console.WriteLine("Введите любое число");
int user_number = int.Parse(Console.ReadLine());
int x = 1;

Console.WriteLine(" Все четные числа от 1 до " + user_number);
while (x < user_number)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
    x++;
}