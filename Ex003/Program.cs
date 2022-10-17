// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

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

void CountElement(int[] array, int[] CountArr)
{
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2==0) CountArr[0]=CountArr[0]+1;
            else CountArr[1]=CountArr[1]+1;
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

int [] CountArr = {0,0}; // создаем массив в который в первую ячейку 
// занесем кол-во четных., во вторую - кол-во нечетных элементов

CountElement(array, CountArr); // считаем количество четн. и нечетн.

PrintArray(array);

Console.WriteLine($"Четных элементов : {CountArr[0]}");
Console.WriteLine($"Нечетных элементов : {CountArr[1]}");
