using LibraryApi.Classes;
using LibraryApi.Requests;
using LibraryApi.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
        new Book { Id = "1", Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", Price = 50, StockQuantity = 1 },
        new Book { Id = "2", Title = "1984", Author = "George Orwell", Genre = "Philosophy", Price = 70, StockQuantity = 2 },
        new Book { Id = "3", Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Romance", Price = 40, StockQuantity = 3 }
        };

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBookById (string id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound(); 
            }

            return Ok(book);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreatedBookJson), StatusCodes.Status201Created)]
        public IActionResult CreateBook([FromBody] RequestCreateBookJson request)
        {
            var response = new ResponseCreatedBookJson
            {
                Id = request.Id,
                Title = request.Title,
                Author = request.Author,
                Genre = request.Genre,
                Price = request.Price,

            };
            return Created(string.Empty, response);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        public IActionResult UpdateBook([FromBody] RequestUpdateBookJson request)
        {
            var response = new ResponseUpdatedBookJson
            {
                Id = request.Id,
                Title = request.Title,
                Author = request.Author,
                Genre = request.Genre,
                Price = request.Price,

            };
            return Ok(response);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete()
        {
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return Ok(books);
        }

    }
}
