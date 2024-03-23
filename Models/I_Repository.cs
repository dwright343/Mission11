namespace Mission11.Models
{
    public interface I_Repository
    {
        IEnumerable<Book> Books { get; }
    }
}
