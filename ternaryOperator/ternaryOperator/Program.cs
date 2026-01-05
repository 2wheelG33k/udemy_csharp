namespace ternaryOperator;

class Program
{
    static void Main(string[] args)
    {
        string nationality = "French";
        bool isFrench = (nationality == "French" ? true : false);
        Console.WriteLine(isFrench);

        int years = 30;
        string userStatus = (years < 18 ? "Minor" : "Adult");
        Console.WriteLine(userStatus);
    }
}