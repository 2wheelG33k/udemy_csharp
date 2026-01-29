namespace radiusAreaHeightCircle;

public class Cylinder : AreaCalculator
{
    protected double height;
    protected double volume;
    
    public void SetHeight(double h)
    {
        height = h;}
    
    public double GetHeight()
    {
        return height;
    }
    
    public void CalculateVolume()
    {
        volume = area * height;
    }
    
}