﻿Console.WriteLine("Введите число 2 и более");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 2) 
{
    Console.WriteLine("Создание числового ряда невозможно, необходимо ввести число больше 1");
}
string res ="";
for (int i = 2; i <= n; i = i + 2)
{
    res = res + $"i = {i}, ";
}

Console.Write(res.TrimEnd(' ').TrimEnd(',')+".");
