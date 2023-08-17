Console.WriteLine("Введите число");
string? n = Console.ReadLine()?.TrimStart('-'); 
if (n == null || n.Length <= 2)
{
    Console.WriteLine("Число состоит из менее 3 цифр");
}
else
{
    char res = n[2];
    Console.WriteLine($"Третья цифра числа = {res}");
}
