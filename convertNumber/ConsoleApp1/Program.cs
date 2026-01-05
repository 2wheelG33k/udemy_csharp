namespace ConsoleApp1;

class Program
{
    public static string ConvertNumber(int number)
    {
        string result;
        if (number > 0)
        {
            result = "Positive";
        }
        else if (number < 0)
        {
            result = "Negative";
        }
        else
        {
            result = "Zero";
        }
        return result;
    }

    public static void DisplayResult(int number, string result)
    {
        Console.WriteLine($"Number {number} is {result}");
    }
    
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        string convertedNumber = ConvertNumber(number);
        DisplayResult(number, convertedNumber);
    }
}