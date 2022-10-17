// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива 

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

void SumElement(int[] array, int[] SumArr)
{
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<0) SumArr[0]=SumArr[0]+array[i];
            else SumArr[1]=SumArr[1]+array[i];
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

int [] SumArr = {0,0}; // создаем массив в который в первую ячейку 
// занесем сумму отриц., во вторую - сумму положительных элементов

SumElement(array, SumArr); // считаем количество отриц. и положит.

PrintArray(array);

Console.WriteLine($"сумма отрицательных элементов : {SumArr[0]}");
Console.WriteLine($"сумма положительных элементов : {SumArr[1]}");