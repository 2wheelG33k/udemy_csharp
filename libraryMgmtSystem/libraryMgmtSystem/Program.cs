namespace libraryMgmtSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the library name: ");
        string libraryName = Console.ReadLine();
        
        Console.WriteLine($"Enter the maximum number of books: ");
        int maxBooks = int.Parse(Console.ReadLine());
        
        Library myLibrary = new Library(libraryName, maxBooks);
        
        Console.WriteLine("\nEnter book titles: ");
        do 
        {
            string input = Console.ReadLine();
            myLibrary.AddBook(input);
            maxBooks--;
        } while (maxBooks >= 0);
        
        myLibrary.DisplayBooks();
        
    }
}