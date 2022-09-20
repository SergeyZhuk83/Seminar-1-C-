Console.WriteLine("Введите три любых целых числа");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int max = A;

if (B > max)         
{
    max = B;
}
if (C > max)         
{
    max = C;
}

Console.WriteLine("max = " + max);