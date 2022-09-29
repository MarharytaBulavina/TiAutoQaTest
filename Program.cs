// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter coordinate x of dot A");
double xOfDotA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate y of dot A");
double yOfDotA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate x of dot B");
double xOfDotB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate y of dot B");
double yOfDotB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate x of dot C");
double xOfDotC = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate y of dot C");
double yOfDotC = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

double lengthAB = Math.Sqrt((Math.Pow((xOfDotB - xOfDotA), 2)) + (Math.Pow((yOfDotB - yOfDotA), 2)));
Console.WriteLine($"The length of AB is " + lengthAB);

double lengthBC = Math.Sqrt((Math.Pow((xOfDotC - xOfDotB), 2)) + (Math.Pow((yOfDotC - yOfDotB), 2)));
Console.WriteLine($"The length of BC is " + lengthBC);

double lengthAC = Math.Sqrt((Math.Pow((xOfDotC - xOfDotA), 2)) + (Math.Pow((yOfDotC - yOfDotA), 2)));
Console.WriteLine($"The length of AC is " + lengthAC);

Console.WriteLine();

if (lengthAB == lengthBC && lengthAB == lengthAC)
{
    Console.WriteLine("Triangle is equilateral");
}
else
{
    Console.WriteLine("Triangle is NOT equilateral");
}

if (lengthAB == lengthBC || lengthAB == lengthAC || lengthBC == lengthAC)
{
    Console.WriteLine("Triangle is isosceles");
}
else
{
    Console.WriteLine("Triangle is NOT isosceles");
}

if (Math.Pow(lengthAC, 2) == (Math.Pow(lengthAB, 2) + Math.Pow(lengthBC, 2)) || Math.Pow(lengthAB, 2) == (Math.Pow(lengthAC, 2) + Math.Pow(lengthBC, 2)) || Math.Pow(lengthBC, 2) == (Math.Pow(lengthAB, 2) + Math.Pow(lengthAC, 2)))
{
    Console.WriteLine("Triangle is right");
}
else
{
    Console.WriteLine("Triangle is NOT right");
}

Console.WriteLine();

double Perimeter = lengthAB + lengthAC + lengthBC;
Console.WriteLine($"Perimeter: " + Perimeter);

Console.WriteLine();

int i = 0;
while ( i < Perimeter)
{
    Console.WriteLine(i);
    i = i + 2;
}