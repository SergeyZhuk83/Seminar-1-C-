// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

int ReadData(string msg) // Общается с пользователем.
{
    Console.Write(msg); // Выводит сообщение пользователю.
    int number = int.Parse(Console.ReadLine()); // Метод ReadLine получает это число и передает 
    // методу Parse, который превратит его в целочисленное число и положит в переменную number.
    return number; // Возвращаем переменную на верх нашего метода.
}

int SumDigitOneToA(int numA) // Вычисляет то, что нужно.
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum += i;
    }
    return sum;
}

int GaussMethod(int numA)
{
    int sum = ((1 + numA) * numA) / 2;
    return sum;
}

void PrintData(string msg, int value) // Возвращает значение.
{
    Console.WriteLine(msg + value);
}

int numA = ReadData("Введите число А: ");
DateTime d1 = DateTime.Now;
int sum = SumDigitOneToA(numA);
Console.WriteLine(DateTime.Now-d1);

PrintData("Сумма чисел от 1 до А(simple): " ,sum);

DateTime d2 = DateTime.Now;
int sumGauss = GaussMethod(numA);
Console.WriteLine(DateTime.Now-d2);


PrintData("Сумма чисел от 1 до А(gause): " ,sumGauss);

