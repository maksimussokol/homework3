Console.Clear();
Console.WriteLine("enter the number");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < x; i++)
{
    if (i == x)
        Console.Write(i * i * i);
    else
        Console.Write(i * i * i + ",");
}