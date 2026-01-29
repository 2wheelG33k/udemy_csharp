namespace radiusAreaHeightCircle;

public class AreaCalculator : Circle
{
    protected double area;
    
    public void CalculateArea()
    {
        area = Math.PI * Math.Pow(Radius, 2);}
    
    public double GetArea()
    {
        return area;}
}