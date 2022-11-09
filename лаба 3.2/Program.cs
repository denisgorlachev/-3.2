//Горлачев средний уровень 
Console.WriteLine("Введите число m: ");
double m = double.Parse(Console.ReadLine());
double sub = 0;
for (int n = 1; n < 1000; n++)
{
    sub = Math.Pow(n, 2) - Math.Pow(m, 2);
}
Console.WriteLine("Ответ: " + sub);