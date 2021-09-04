using Library.Models;
using Library.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly ClientService _clientService;

        private String CLientId => User.Claims.Single(c => c.Type == ClaimTypes.NameIdentifier).Value;

        public BooksController(BookService bookService, ClientService clientService)
        {
            _bookService = bookService;
            _clientService = clientService;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get() =>
            _bookService.Get();

        [HttpGet("GetBook/{id:length(24)}", Name = "GetBook")]
        public ActionResult<Book> GetBook(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpGet("GetFiltered/{genre}", Name = "GetFiltered")]
        public ActionResult<List<Book>> GetFiltered(string genre)
        {
            var book = _bookService.GetFiltered(genre);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpGet("GetClientBooks")]
        [Authorize]
        public IActionResult GetClientBooks()
        {
            var client = _clientService.Get().FirstOrDefault(x => x.Id == CLientId);
            var books = new List<Book>();
            foreach(var boksid in client.BooksId)
            {
                books.Add(_bookService.Get(boksid));
            }
            if(books.Count > 0)
            {
                return Ok(books);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            _bookService.Create(book);

            return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Book bookIn)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Update(id, bookIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Remove(book.Id);

            return NoContent();
        }
    }
}
