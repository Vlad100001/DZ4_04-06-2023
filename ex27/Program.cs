Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int k =0;
while (n > 0)
{
    k=k+n%10;
    n = n / 10;
}
Console.WriteLine($"Сумма {k} ");