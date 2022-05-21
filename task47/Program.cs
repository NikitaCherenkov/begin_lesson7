// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

var rand = new Random();
Console.WriteLine("Введите количество строк массива m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] array = new double[m, n];
for (int i = 0; i < m; i++) {
    for (int l = 0; l < n; l++) {
        array[i, l] = rand.Next() - rand.NextDouble() * rand.Next();
        Console.Write($"{array[i, l]:F1} ");
    }
    Console.WriteLine();
}