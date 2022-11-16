Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int num = 1;
while (num <= A)
{
    if (num % 2 == 0) Console.Write($"{num} ");
    num++;
}