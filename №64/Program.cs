Console.WriteLine("Введите значение M: ");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите значение N (должно быть больше M): ");
int N = Convert.ToInt32 (Console.ReadLine());
int [] ar = new int [N-M+1];
for (int i = 0; i<ar.Length; i++ )
{
    ar [i] = ar [i] + M;
    M++;
    Console.Write ($"{ar[i]} , ");
}

