//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да
bool Palindrome(int n)
{
    int rev = 0, r, check = n;

    while (n > 0)
    {
        r = n % 10;
        rev = rev * 10 + r;
        n = n / 10;
    }
    return check==rev;
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
bool palindrome = Palindrome(num);
string result = palindrome == true
? ("Число является палиндромом")
: ("Число не является палиндромом");
Console.WriteLine(result);
