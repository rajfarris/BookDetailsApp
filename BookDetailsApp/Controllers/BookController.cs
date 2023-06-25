using BookDetailsApp.Models;
using BookDetailsApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookDetailsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("sorted-by-publisher-author-title")]
        public async Task<ActionResult<List<Book>>> GetBooksSortedByPublisherAuthorTitle()
        {
            var sortedBooks = await _bookRepository.GetBooksSortedByPublisherAuthorTitleAsync();
            return sortedBooks;
        }

        [HttpGet("sorted-by-author-title")]
        public async Task<ActionResult<List<Book>>> GetBooksSortedByAuthorTitle()
        {
            var sortedBooks = await _bookRepository.GetBooksSortedByAuthorTitleAsync();
            return sortedBooks;
        }

        [HttpGet("total-price")]
        public async Task<ActionResult<decimal>> GetTotalPriceOfAllBooks()
        {
            var totalPrice = await _bookRepository.GetTotalPriceOfAllBooksAsync();
            return totalPrice;
        }

        [HttpPost("insert-books")]
        public async Task<IActionResult> InsertBooks(List<Book> books)
        {
            await _bookRepository.InsertBooksAsync(books);
            return Ok();
        }
        [HttpPost("bulk-insert-books")]
        public async Task<IActionResult> BulkInsertBooks(List<Book> books)
        {
            await _bookRepository.BulkInsertBooksAsync(books);
            return Ok();
        }
    }
}
