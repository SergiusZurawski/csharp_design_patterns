
using System.Collections;

namespace csharp_design_patterns.behavioural.iterator.implementation;

// Custom IEnumerator for iterating over books
public class BookEnumerator : IEnumerator<Book>
{
    private readonly List<Book> _books;
    private int _position = -1;

    public BookEnumerator(List<Book> books)
    {
        _books = books;
    }

    public Book Current
    {
        get
        {
            try
            {
                return _books[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        _position++;
        return (_position < _books.Count);
    }

    public void Reset()
    {
        _position = -1;
    }

    public void Dispose()
    {
        // Implement if needed for cleanup
    }
}  