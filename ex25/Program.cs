// Вариант1
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень : ");
int k = int.Parse(Console.ReadLine()!);
int s = 1;
if (n!=0 && k>0) 
{int[] array = new int[k]; 
for (int i = 0; i < array.Length; i++)
    array[i] = n; 
for (int i = 0; i < array.Length; i++)
    s= s*array[i]; 
Console.WriteLine( s);}
 else if (k==0)
Console.WriteLine ("=1");
else if (k<0)
Console.WriteLine ("Ошибка");
else 
Console.WriteLine ("=0");


// Вариант 2 не получлся
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень : ");
// int k = int.Parse(Console.ReadLine()!);
// //  if (k==0) 
// //         return "1";
// //     else if (n ==0)
// //         return "0";
// //     else
// //      int Summa(int n, int k)
// //       {int result = 1;
// //       for (int i = 1; i <= k; i++)
// //         {
// //             result = result * n;
// //         }
// //        return "result";
    