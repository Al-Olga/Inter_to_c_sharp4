// В Указанном массиве вещественных чисел найдите 
// разницу между максимальным и минимальным элементом

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}"+"; ");
        }
    Console.WriteLine();
}

void GenerateMassiv(double[] array)
{
    Random random = new Random();
    for (int i=0; i<array.Length; i++)
    {
       // array[i] =Convert.ToDouble((new Random().Next(min,max))/10.00);
       array[i] =new Random().NextDouble()*100;
    }
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i=0; i<array.Length; i++) 
    {                      
        if (min>array[i]) min = array[i];
    } 
    return min;
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i=0; i<array.Length; i++) 
    {                      
        if (max<array[i]) max = array[i];
    } 
    return max;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");

double[] array = new double[length];

GenerateMassiv(array); // заполняем массив элементами

PrintArray(array);

double MinEl = MinElement(array);
double MaxEl = MaxElement(array);
double razn =  MaxEl - MinEl;
Console.WriteLine($"разница между минимальным ({MinEl}) и максимальным ({MaxEl}) = {razn}");