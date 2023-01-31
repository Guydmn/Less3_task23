// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите число которое хотите возвести в куб: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"{Math.Pow(i, 3)}");
}