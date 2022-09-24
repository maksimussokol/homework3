Console.Clear();
Console.Write("enter x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write("rasstoyanie mezdu tochkami ravno ");
Console.WriteLine(Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2));
