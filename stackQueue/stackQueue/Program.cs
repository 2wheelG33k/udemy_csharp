using System.Text;

namespace stackQueue;

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Queue q = new Queue();
        Stack<string> s = new Stack<string>();
        int randomNumber = rnd.Next(1, 101);
        int attempts = 0;
        int userGuess = 0;
        
        Console.WriteLine("Welcome to the number guessing game!\n\n");

        do
        {
            Console.WriteLine("Please enter your guess:");
            userGuess = Int32.Parse(Console.ReadLine());
            q.Enqueue(userGuess);
            s.Push(userGuess.ToString());
            attempts += 1;
            if (userGuess < randomNumber)
            {
                Console.WriteLine("Your guess is too low. Try again\n");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Your guess is too high. Try again\n");
            }
        } while (userGuess != randomNumber);
        
        Console.WriteLine("YOU WIN!");
        Console.WriteLine($"Total number of guesses: {attempts}");
        var sb = new StringBuilder();
        foreach(var e in q) { 
            sb.Append(e.ToString() + ","); 
        }
        string queueString = sb.ToString();
        Console.WriteLine($"Queue: {queueString}");
        
        var st = new StringBuilder();
        while (s.Count > 0)
        {
            st.Append(s.Pop().ToString());
            st.Append(", ");
        }
        string stackString = st.ToString();
        Console.WriteLine($"Stack: {stackString}");

    }
}