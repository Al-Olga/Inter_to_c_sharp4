// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

void MultElement(int[] array)
{
    int BegEl = 0;
    int EndEl = array.Length-1;
    int multipl = 0;
    while (BegEl <= EndEl)  // здесь, если в массиве нечетное число элементов, 
    {                       // то у центрального элемента пары нет и оно умножается на себя же. 
                            // Если так не нужно, то в условии ставим строго "<" и тогда умножения 
                            // центрального числа на себя самого не будет
        multipl = array[BegEl]*array[EndEl];
        Console.WriteLine($"произведение пары {array[BegEl]} и {array[EndEl]} = {multipl}");
        BegEl++;
        EndEl--;
    } 
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

MultElement(array); // считаем произведение пары и выводим в консоль
