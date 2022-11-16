Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    Console.WriteLine($"Число A больше B. A={A} B={B}");
}
else
{
    Console.WriteLine($"Число B больше A. A={A} B={B}");
}