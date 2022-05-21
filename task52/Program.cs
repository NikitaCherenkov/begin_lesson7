// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк массива");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[line, column];
for (int k = 0; k < line; k++) {
    Console.WriteLine($"Заполните {k + 1} строку массива");
    for (int i = 0; i < column; i++) {
        Console.WriteLine($"Введите элемент {i + 1}");
        array[k, i] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Среднее арифметическое каждого столбца: ");
double[] average = new double[column];
for (int a = 0; a < column; a++) {
    for (int b = 0; b < line; b++) {
        average[a] = average[a] + array[b, a];
    }
    average[a] = average[a] / line;
    Console.Write($"{average[a]} ");
}