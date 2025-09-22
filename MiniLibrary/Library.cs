namespace MiniLibrary
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book b)
        {
            if (b != null)
                books.Add(b);
        }

        public Book FindByTitle(string title)
        {
            return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public bool Lend(string title, Member m)
        {
            var book = FindByTitle(title);
            if (book == null || m == null)
                return false;
            return m.BorrowBook(book);
        }

        public bool TakeBack(string title, Member m)
        {
            var book = FindByTitle(title);
            if (book == null || m == null)
                return false;
            return m.ReturnBook(book);
        }

        public void PrintInventory()
        {
            Console.WriteLine("\nLibrary Inventory:");
            foreach (var book in books)
            {
                Console.WriteLine($" - {book.Title} by {book.Author} | Available: {book.IsAvailable}");
            }
        }
    }
}