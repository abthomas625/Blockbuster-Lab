namespace Blockbuster_Lab
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to GC Blockbuster!");

            Blockbuster blockbuster = new Blockbuster();
            Movie movieChoice = blockbuster.CheckOut();
            
            Console.WriteLine($"\nWould you like to play {movieChoice.Title}? Y/N");
            string response = Console.ReadLine().Trim().ToLower();
            if(response == "y")
            {
                if(movieChoice is DVD)
                {
                    movieChoice.Play();
                    Console.WriteLine("\nWould you like to watch another scene? Y/N");
                    string playDVDAgain = Console.ReadLine().Trim().ToLower();
                    if(playDVDAgain == "y")
                    {
                        movieChoice.Play();                        
                    }
                    else if (playDVDAgain == "n")
                    {
                        Console.WriteLine("Thank you for watching! Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("I didn't understand that. Please try that again.");
                        return;
                    }
                }
                else
                {
                    movieChoice.Play();
                    Console.WriteLine($"Would you like to watch {movieChoice.Title} again? Y/N");
                    string playVHSAgain = Console.ReadLine().Trim().ToLower();
                    if(playVHSAgain == "y")
                    {
                        movieChoice.Play();
                    }
                    else if (playVHSAgain == "n")
                    {
                        Console.WriteLine("Thank you for watching! Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("I didn't understand that. Please try that again.");
                        return;
                    }
                }
            }
            else if(response == "n")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("I didn't understand that. Please try that again.");
                return;
            }
        }
    }
}