using System.Numerics;

Console.WriteLine("Enter second vector");
float x2 = float.Parse(Console.ReadLine());
float y2 = float.Parse(Console.ReadLine());
float z2 = float.Parse(Console.ReadLine());

Vector3 B = new Vector3(x2, y2, z2);

int x  = int.Parse(Console.ReadLine());
Vector3 minVector = new Vector3();
float min = int.MaxValue;
for (int i = 0; i < x; i++)
{
    float x1 = float.Parse(Console.ReadLine());
    float y1 = float.Parse(Console.ReadLine());
    float z1 = float.Parse(Console.ReadLine());
    Vector3 A = new Vector3(x1, y1, z1);
    if (min > A.Length())
    {
        min = A.Length();
        minVector = A;
    }
}
Console.WriteLine(BA.Length());
if (A.Length() > B.Length())
{
    Console.WriteLine("B is closer");
}
else
{
    Console.WriteLine("A is closer");
}
var AB = A - B;
var Plus = A + B;
int x = 5;
var multi = x * A;
var multiply = A * B;
