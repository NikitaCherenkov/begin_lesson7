// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

var rand = new Random();
Console.WriteLine("Введите количество строк массива");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] array = new double[line, column];
for (int k = 0; k < line; k++) {
    Console.WriteLine($"Заполните {k + 1} строку массива");
    for (int i = 0; i < column; i++) {
        Console.WriteLine($"Введите элемент {i + 1}");
        array[k, i] = Convert.ToDouble(Console.ReadLine());
        if (!IsEven(k + 1) & !IsEven(i + 1)) array[k, i] = array[k, i] * array[k, i];
    }
}
for (int a = 0; a < line; a++) {
    for (int b = 0; b < column; b++) {
        Console.Write($"{array[a, b]} ");
    }
    Console.WriteLine();
}

bool IsEven(double number) {
    if (number % 2 == 0) {
        return true;
    } else {
        return false;
    }
}