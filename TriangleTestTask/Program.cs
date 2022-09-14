// See https://aka.ms/new-console-template for more information

// Asking coordinates

Console.WriteLine("Enter coordinate x of dot A");
double ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate x of dot B");
double bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate x of dot C");
double cx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y of dot A");
double ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y of dot B");
double by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y of dot C");
double cy = Convert.ToInt32(Console.ReadLine());

// Line lengts
double ab = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)),
    bc = Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow(by - cy, 2)),
    ac = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));

Console.WriteLine("Length of AB " + ab);
Console.WriteLine("Length of BC " + bc);
Console.WriteLine("Length of AC " + ac);

// Equilateral
bool IsAlmostEqual(double source, double value)
{
    return Math.Abs(source - value) < 1e-9;
}

if (ab + bc > ac || ab + ac > bc || ac + bc > ab)
{
    if (IsAlmostEqual(ab, bc) && IsAlmostEqual(bc, ac))
        Console.WriteLine("Triangle is equilateral");
    else
        Console.WriteLine("Triangle is not equilateral");
}

// Isosceles    

if (IsAlmostEqual(ab, ac) || IsAlmostEqual(bc, ac) || IsAlmostEqual(ab, bc))
    Console.WriteLine("Triangle is isoscele");
else
    Console.WriteLine("Triangle is not isoscele");

// Right      

if (IsAlmostEqual(ab * ab, bc * bc + ac * ac) ||
    IsAlmostEqual(bc * bc, ac * ac + ab * ab) ||
    IsAlmostEqual(ab * ab, bc * bc + ac * ac))
    Console.WriteLine("Triangle is right");
else
    Console.WriteLine("Triangle is not right");

// Perimeter

var perimetr = ab + bc + ac;
Console.WriteLine("Perimetr is " + perimetr);

// Even numbers from 0 to value of triangle perimeter.     

for (var i = 0; i <= perimetr; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);