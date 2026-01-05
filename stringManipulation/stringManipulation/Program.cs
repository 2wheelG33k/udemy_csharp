namespace stringManipulation;

class Program
{
    static void Main(string[] args)
    {
        int employeeId = 20;
        string companyName = "UTCLI";

        Console.WriteLine("Hello, my employee ID is " + employeeId + " and my company name is " + companyName);
        
        Console.WriteLine("Hello, my employee ID is {0} and my company name is {1}", employeeId, companyName);

        Console.WriteLine($"Hello, my employee ID is {employeeId} and my company name is {companyName}");
    }
}