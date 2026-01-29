namespace radiusAreaHeightCircle;

class Program
{
    static void Main(string[] args)
    {
        Cylinder cylinder = new Cylinder();

        Console.WriteLine("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the circle: ");
        double height = double.Parse(Console.ReadLine());

        cylinder.SetRadius(radius);
        cylinder.SetHeight(height);

        cylinder.CalculateArea();
        cylinder.CalculateVolume();
        
        Console.WriteLine($"Radius of the circle: {cylinder.GetRadius()});
        Console.WriteLine($"Area of the circle: {cylinder.GetArea()}");

    }
}