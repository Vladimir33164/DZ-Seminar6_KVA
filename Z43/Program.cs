//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float b1, k1, b2, k2, x, y; // объявления переменных
Console.Write("Enter the coefficient b1:"); // ввод данных, коэффициенты прямых
b1 = float.Parse(Console.ReadLine());
Console.Write("Enter the coefficient k1:");
k1 = float.Parse(Console.ReadLine());
Console.Write("Enter the coefficient b2:");
b2 = float.Parse(Console.ReadLine());
Console.Write("Enter the coefficient k2:");
k2 = float.Parse(Console.ReadLine());
if (b1 == b2 & k1 == k2)  // если все коэффициенты равны то прямые совпадают
    Console.WriteLine("Straight lines match!");
else 
    if (k1 == k2)  // если коэф-ты k равны, то прямые параллельные
        Console.WriteLine("Straight lines are parallel!");
    else
    {
        x = (b2 - b1) / (k1 - k2); // иначе вычисляем точку пересечения
        y = k1 * x + b1;
        Console.WriteLine("Intersection point (" + x + ";" + y + ")");
    }
