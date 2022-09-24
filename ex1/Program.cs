Console.Clear();
Console.WriteLine("enter number between 10000 and 99999");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 10000 || x > 99999)
{
    Console.WriteLine("error");
}
else
{

}
int a = x / 10000;
int b = x / 1000;
int c = x / 10;
int d = x % 10;
if (a == d || b == c)
{
    Console.WriteLine("its a palindrom");
}
else
    Console.WriteLine("its NOT a palindrom");