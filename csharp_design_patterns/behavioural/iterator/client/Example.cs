
using csharp_design_patterns.behavioural.iterator.implementation;

namespace csharp_design_patterns.behavioural.iterator.client;

public static class Example
{
    public static void ExecuteExample()
    {
        var library = new Library();
        library.AddBook(new Book { Title = "1984", Author = "George Orwell" });
        library.AddBook(new Book { Title = "Brave New World", Author = "Aldous Huxley" });

        foreach (Book book in library)
        {
            Console.WriteLine($"Book: {book.Title}, Author: {book.Author}");
        }
    }

}