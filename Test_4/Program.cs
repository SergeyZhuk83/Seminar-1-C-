using System;
int NumberOne(int num, int NumberOfFirstNumbers)// Узнаем первые два числа
{ 
    while (num / Math.Pow(10,NumberOfFirstNumbers)  > 1)
    {
        num/=10;
    }
    return num;
}

int number = int.Parse(Console.ReadLine());
if(number < 0 ) number *=-1;
if(number > 99)
{
    int x = number % 100;
    Console.WriteLine(NumberOne(number,2));// Указываем сколько первых цифр хотим получить
}
else if(number > 9)
{
    int x = number % 10;
}
else
{
    Console.WriteLine("Введите число больше 9");
}
// Найти полиндромное число можно с помощью: if(x/10 == y%10 && x%10 ==y/10)