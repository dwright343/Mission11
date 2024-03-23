namespace Mission11.Models.ViewModels
{
    public class DefaultListViewModel
    {
        public IEnumerable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}