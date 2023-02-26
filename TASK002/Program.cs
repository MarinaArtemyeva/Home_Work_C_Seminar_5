//Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Random rand = new Random();
            int[] a;
            Console.Write("Введите размер массива (не более 10): ");
            n = int.Parse(Console.ReadLine());
            a = new int [n];
            Console.Clear();
            Console.WriteLine("Исходный массив:");
                
            for (int i = 0; i < n; i++)
                {
                    a[i] = rand.Next(-10,10);
                    Console.Write("{0,5}", a[i]);
                }
            Console.WriteLine();
    
            for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                    sum = sum + a[i];
                    }
                }
            Console.WriteLine("Сумма элементов с нечетными номерами: {0} ", sum);
            Console.ReadKey();
        }
    }
}