namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int salary = 80000;
        
        if (salary < 18200)
        {Console.WriteLine("Tax Bracket: No Tax");}
        else if (salary >= 18200 && salary < 37000)
        {Console.WriteLine("Tax Bracket: Low");}
        else if (salary >= 37000 && salary < 90000)
        {Console.WriteLine("Tax Bracket: Medium");}
        else if (salary >= 90000 && salary < 180000)
        {Console.WriteLine("Tax Bracket: High");}
        else if (salary >= 180000)
        {Console.WriteLine("Tax Bracket: Very High");}
    }
}