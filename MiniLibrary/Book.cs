using System;

namespace MiniLibrary
{
    // Class 1: Book
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public bool IsAvailable { get; private set; } = true;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
            }
            else
            {
                //  Do nothing
            }
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }
}