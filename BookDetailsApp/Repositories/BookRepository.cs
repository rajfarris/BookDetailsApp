using BookDetailsApp.Data;
using BookDetailsApp.Models;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace BookDetailsApp.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext _dbContext;

        public BookRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<decimal> GetTotalPriceOfAllBooksAsync()
        {
            return await _dbContext.Books.SumAsync(b => b.Price);
        }

        public async Task<List<Book>> GetBooksSortedByPublisherAuthorTitleAsync()
        {
            //return await _dbContext.Books.OrderBy(b => b.Publisher)
            //    .ThenBy(b => b.AuthorLastName)
            //    .ThenBy(b => b.AuthorFirstName)
            //    .ThenBy(b => b.Title)
            //    .ToListAsync();
            var sortedBooks = await _dbContext.Books
                .FromSqlRaw("EXEC GetBooksSortedByPublisherAuthorTitle")
                .ToListAsync();

            return sortedBooks;
        }

        public async Task<List<Book>> GetBooksSortedByAuthorTitleAsync()
        {
            //return await _dbContext.Books.OrderBy(b => b.AuthorLastName)
            //    .ThenBy(b => b.AuthorFirstName)
            //    .ThenBy(b => b.Title)
            //    .ToListAsync();
            var sortedBooks = await _dbContext.Books
            .FromSqlRaw("EXEC GetBooksSortedByAuthorTitle")
            .ToListAsync();

            return sortedBooks;
        }

        public async Task InsertBooksAsync(List<Book> books)
        {
            await _dbContext.Books.AddRangeAsync(books);
            await _dbContext.SaveChangesAsync();
        }
        public async Task BulkInsertBooksAsync(List<Book> books)
        {
            await _dbContext.BulkInsertAsync(books);
        }
    }
}
