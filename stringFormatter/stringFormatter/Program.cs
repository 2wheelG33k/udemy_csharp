namespace stringFormatter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a string to format:");
        
        string userInput = Console.ReadLine();
        
        string userUpper = userInput.ToUpper();
        
        Console.WriteLine(userUpper);

        char[] stringArray = userInput.ToCharArray();
        Array.Reverse(stringArray);
        string userReversed = new string(stringArray);
        
        Console.WriteLine(userReversed);
        
        string userNoSpace = userInput.Replace(" ", "_");

        Console.WriteLine(userNoSpace);

        Console.WriteLine(userInput);
    }
}