// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}"+"; ");
        }
    Console.WriteLine();
}

void GenerateMassiv(int [] array, int min, int max)
{
    Random random = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
}

int CountElement(int[] array, int Diap1, int Diap2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if ((array[i]>=Diap1) & (array[i]<=Diap2)) count=count+1;
        }
    return count;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный элемент: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент: ");
int max = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите начало диапазона поиска: ");
int Diap1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите окончание диапазона поиска: ");
int Diap2 = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[length];

GenerateMassiv(array, min, max); // заполняем массив элементами

PrintArray(array);

int CountEl = CountElement(array, Diap1, Diap2); // считаем и возвращаем количество в диапазоне
Console.WriteLine($"Количество элементов в диапазоне [{Diap1},{Diap2}] : {CountEl}");
