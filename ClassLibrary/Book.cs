namespace ClassLibrary
{
    public class Book
    {
        public string Author;
        public string Title;
        public string Publisher;

        public void WriteToConsole()
        {
            Console.WriteLine($"Szerző: {Author}");
            Console.WriteLine($"Cím: {Title}");
            Console.WriteLine($"Kiadó: {Publisher}");
        }
    }
}