using ATest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ATest.Controllers
{
    public class BookController : ApiController
    {

        List<Book> books = new List<Book>();

        public BookController() { }

        public BookController(List<Book> Books)
        {
            this.books = Books;
        }
        Book Book = null;
        Book[] book = new Book[]{
         new Book { Id=1,Author="John Smith",Title="SRE 101"},
         new Book{ Id=2,Author="Jane Archer", Title="DevOps is a lie"}};


        [HttpGet]
        [Route("api/Book/list")]
        public IHttpActionResult GetBookList()
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(book);
        }


        [HttpGet]
        [Route("api/Book/get")]
        public IHttpActionResult GetBook(int id)
        {
           
            Book = book.FirstOrDefault(x => x.Id == id);
            if(Book !=null )
            {
                return Ok(Book);

            }

            else 
            {
                BadRequest("Bulunamadı");
            }
            return Ok();

        
        }


        [HttpPost]
        [Route("api/Book/post")]
        public IHttpActionResult PostBook([FromBody] Book books)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            book.Append(books);

            return Ok("Eklendi.");

        }

        [HttpPut]
        [Route("api/Book/put")]
        public IHttpActionResult PutBook( int id, [FromBody] Book books)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            books.Id=id;

            if (id != books.Id)
            {
                return BadRequest();
            }
            Book = new Book();
            var result=book.FirstOrDefault(x => x.Id == id);
            if(result!=null)
            {
                Book.Author = books.Author;
                Book.Title = books.Title;
            }


            return Ok("Güncellendi");
            
        }
    }
}
