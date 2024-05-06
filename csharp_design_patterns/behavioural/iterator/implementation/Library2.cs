
using System.Collections;

namespace csharp_design_patterns.behavioural.iterator.implementation;

// Iterable collection class for Books
public class Library2 : IEnumerable<Book>
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Returning an IEnumerator<Book> directly
    public IEnumerator<Book> GetEnumerator()
    {
        foreach (var book in books)
        {
            // Adding custom behavior or filters can be done here
            yield return book;
        }
    }

    // Explicit interface implementation for IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}