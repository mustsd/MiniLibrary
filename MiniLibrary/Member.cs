
namespace MiniLibrary;

public class Member(string name, int id)
{
    public string Name { get; set; } = name;
    public int Id { get; set; } = id;

    private readonly List<Book> borrowedBooks = new List<Book>();

    public bool BorrowBook(Book b)
    {
        if (b == null || !b.IsAvailable)
            return false;

        if (borrowedBooks.Count >= 3)
            return false;

        b.Borrow();
        borrowedBooks.Add(b);
        return true;
    }

    public bool ReturnBook(Book b)
    {
        if (b == null || !borrowedBooks.Contains(b))
            return false;
        b.Return();
        borrowedBooks.Remove(b);
        return true;
    }

    public void PrintBorrowed()
    {
        Console.WriteLine($"\n{Name} has {borrowedBooks.Count} books:");
        foreach (var book in borrowedBooks)
        {
            Console.WriteLine($"- {book.Title} by {book.Author}");
        }
    }
}
