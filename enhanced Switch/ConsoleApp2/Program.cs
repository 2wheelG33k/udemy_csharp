namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        int input = 6;
        string output = input switch
        {
            1 => "First",
            2 => "Second",
            3 => "Third",
            _ => "Other"
        };
        
        Console.WriteLine(output);
    }
}