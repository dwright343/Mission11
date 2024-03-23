namespace Mission11.Models
{
    public class EF_Repository : I_Repository
    {
        private BookstoreContext _BookstoreContext;
        public EF_Repository(BookstoreContext temp)
        {
            _BookstoreContext = temp;
        }

        public IEnumerable<Book> Books => _BookstoreContext.Books;

    }
}