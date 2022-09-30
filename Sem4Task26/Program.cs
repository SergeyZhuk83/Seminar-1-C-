// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.


int ReadData(string msg)
{
    System.Console.Write(msg); 
    int number = int.Parse(System.Console.ReadLine()??"0"); 
    return number;
}
void PrintData(string msg, int value) 
{
    System.Console.WriteLine(msg + value);
}

int CountDigLog(int num)
{
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
int num = ReadData("Введите число = ");
PrintData("Количество цифр в числе" + num + "(CountDigLog равно) = ", CountDigLog(num));
