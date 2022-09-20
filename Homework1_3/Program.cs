Console.WriteLine("Введите любое целое число");
int user_number = int.Parse(Console.ReadLine());

if (user_number % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является не четным");
}