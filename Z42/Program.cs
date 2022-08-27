//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10

Console.Write("Enter a number in the 10th numeral system: "); // ввод данных
int n = int.Parse(Console.ReadLine()); // читаем число
string s = ""; // результирующая строка
while (n > 0) // цикл пока число больше нуля
    {
        s = (n % 2).ToString() + s; // берем остаток от деления на два и записываем в строку в начало
        n = n / 2; // делим нацело число
    }
    
Console.Write("A number in the 2nd number system = " + s); // выводим результат
Console.ReadLine();