using ClassLibrary; 

namespace BookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string author;
            string title;
            string publisher;

            // Adatok bekérése a felhasználótól
            Console.Write("A szerző neve?: ");
            author = Console.ReadLine();

            Console.Write("A könyv címe?: ");
            title = Console.ReadLine();

            Console.Write("A kiadó neve: ");
            publisher = Console.ReadLine();

            Book myBook = new Book();

            myBook.Author = author;
            myBook.Title = title;
            myBook.Publisher = publisher;

            myBook.WriteToConsole();
        }
    }
}