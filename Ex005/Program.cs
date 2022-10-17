// Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

int SumElement(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (i%2!=0) sum=sum+array[i];
        }
    return sum;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный элемент: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент: ");
int max = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[length];

GenerateMassiv(array, min, max); // заполняем массив элементами

PrintArray(array);

int SumEl = SumElement(array); // считаем и возвращаем сумму чисел
Console.WriteLine($"Сумма чисел на нечетной позиции : {SumEl}");
