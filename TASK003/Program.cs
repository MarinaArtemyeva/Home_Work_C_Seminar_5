//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

class Program
{
static void Main(string[] args)
{
Random rnd = new Random();
int[] digital = new int[30];
int max = 0, min = 100;
    for (int i = 0; i < digital.Length; i++ ) digital[i] = rnd.Next(100);
        for (int i = 0; i < digital.Length; i++)
        {
            if (digital[i] > max) max = digital[i];
            if (digital[i] < min) min = digital[i];
        }
        for (int i = 0; i < digital.Length; i++) 
        Console.Write(" " + digital[i]);

Console.WriteLine();
Console.WriteLine("max: " + max);
Console.WriteLine("min " + min);
Console.WriteLine("Разница максимального и минимального: "+(max - min));
Console.ReadKey();
}
}