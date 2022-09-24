


// int[] numbers = new int[10];
// int[] a = {1, 14, 155, 12, 61, 26, 136, 13, 613, 56, 12};
// Console.WriteLine(a[5]);
// 1 - Что мы хотим получить .. (void - ничего, int - число, int[] - числовой массив)
// 2 - Название функции ... (Любым)
// 3 - Что мы хотим отдать ()

int[] CreaterArrayNumber(int size)
{
    int[] array = new int[size];// Создаем массив задавая размер через size
    for (int i = 0; i < size; i++)// Заполняем массив
    {
        array[i] = i+1;
    }
    return array;// Отдаем массив
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] numbers = CreaterArrayNumber(20);
WriteArray(numbers);