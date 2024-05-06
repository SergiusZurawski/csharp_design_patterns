
using System.Collections;

namespace csharp_design_patterns.behavioural.iterator.implementation;

// Iterable collection class for Books
public class Library : IEnumerable<Book>
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Returning an IEnumerator<Book> using a custom enumerator
    public IEnumerator<Book> GetEnumerator()
    {
        return new BookEnumerator(books);
    }

    // Explicit interface implementation for IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}