using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace numArray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number of elements for the array: ");
        int arraySize = Convert.ToInt32(Console.ReadLine());
        int[] userNumbers = new int[arraySize];
        int sum = 0;
        double average = 0;
        
        for (int i=0; i < arraySize; i++)
            {
                Console.WriteLine($"Enter #{i+1}): ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                userNumbers[i] =  userInput;
            }

        for (int s = 0; s < userNumbers.Length; s++)
            {
                sum +=  userNumbers[s];
            }
        Console.WriteLine($"The sum of array numbers is: {sum}");
        average = sum / userNumbers.Length;
        Console.WriteLine($"The average of array numbers is: {average}");
        
        
    }
}