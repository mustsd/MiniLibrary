using MiniLibrary;
using System;

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("1984", "George Orwell");
        Book b2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book b3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Book b4 = new Book("The Catcher in the Rye", "J.D. Salinger");
        Book b5 = new Book("Moby Dick", "Herman Melville");

        Member m1 = new Member("Alice", 1001);
        Member m2 = new Member("Bob", 1002);

        Library lib = new Library();

        lib.AddBook(b1);
        lib.AddBook(b2);
        lib.AddBook(b3);
        lib.AddBook(b4);
        lib.AddBook(b5);

        lib.PrintInventory();

        // Lend books to Alice
        Console.WriteLine($"Lend '{b1.Title}' to {m1.Name}: {lib.Lend(b1.Title, m1)}");
        Console.WriteLine($"Lend '{b2.Title}' to {m1.Name}: {lib.Lend(b2.Title, m1)}");
        Console.WriteLine($"Lend '{b3.Title}' to {m1.Name}: {lib.Lend(b3.Title, m1)}");
        Console.WriteLine($"Lend '{b4.Title}' to {m1.Name}: {lib.Lend(b4.Title, m1)}");

        m1.PrintBorrowed();

        // return a book
        Console.WriteLine($"\nTake back '{b1.Title}' from {m1.Name}: {lib.TakeBack(b1.Title, m1)}");

        Console.WriteLine($"Alice returns '{b1.Title}'");

        m1.PrintBorrowed();

        // Lend a book to Bob
        Console.WriteLine($"\nLend '{b5.Title}' to {m2.Name}: {lib.Lend(b5.Title, m2)}");

        lib.PrintInventory();

        m2.PrintBorrowed();
    }
}