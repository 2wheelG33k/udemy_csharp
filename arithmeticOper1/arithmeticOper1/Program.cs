namespace arithmeticOper1;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 8;
        
        int total = num1 + num2;
        
        Console.WriteLine($"{num1} + {num2} = {total}");

        int count = 10;

        count += 5;
        
        Console.WriteLine($"The value of count is {count}");
    }
}