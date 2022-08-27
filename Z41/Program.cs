//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int M, count = 0; // объявления переменных
float a;
Console.Write("Enter a natural number M: ");
M = int.Parse(Console.ReadLine()); // ввод количества чисел
Console.WriteLine("Enter M numbers: ");
for (int i = 1; i <= M; i++) // в цикле вводим M чисел
    {    
        a = float.Parse(Console.ReadLine());
        if (a > 0) // и проверяем если число больше нуля, то
            count++; // увеличиваем счетчик
    }
Console.WriteLine("The number of numbers greater than zero = " + count); // вывод результата