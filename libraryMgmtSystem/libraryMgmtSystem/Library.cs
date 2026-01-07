namespace libraryMgmtSystem;

internal class Library
{
    private string LibraryName;
    private int bookEntered;
    private int bookCounts = 0;
    
    public Library(string name, int maxBooks)
        {
        LibraryName = name;
        bookEntered = maxBooks;
        Console.WriteLine($"Library Name: {LibraryName} is created");
        }
    
    public string LibaryName
        {
            get
            {
                return LibraryName;
            }
            set {
                LibraryName = value;
            }
        }

    public void AddBook(string bookTitle)
    {
        if (bookEntered > 0)
        {
            bookCounts++;
            Console.WriteLine($"Book '{bookTitle}' has been added");
            bookEntered--;
        }
        else
        {
            Console.WriteLine("Library is full. Cannot add more books.");
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine($"Books available in the '{LibraryName}' are: {bookCounts}");
    }
    
    ~Library()
    {
        Console.WriteLine($"Library Name: {LibraryName} has been deleted");
    }
}