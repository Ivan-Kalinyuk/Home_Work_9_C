Console.WriteLine("Введите  значение M: ");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите  значение N (большее, чем M): ");
int N = Convert.ToInt32 (Console.ReadLine());
int sum = 0;
int p = N-M+1;
for (int i = 0; i < p; i++)
{
    sum = sum + M;
    M++;
}
Console.WriteLine($"Сумма чисел от M до N = {sum}");