using BookDetailsApp.Models;

namespace BookDetailsApp.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<decimal> GetTotalPriceOfAllBooksAsync();
        Task<List<Book>> GetBooksSortedByPublisherAuthorTitleAsync();
        Task<List<Book>> GetBooksSortedByAuthorTitleAsync();
        Task InsertBooksAsync(List<Book> books);
        Task BulkInsertBooksAsync(List<Book> books);
    }
}
