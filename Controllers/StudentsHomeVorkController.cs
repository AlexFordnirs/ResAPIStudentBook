using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Repositories;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsHomeVorkController : Controller
    {
        private readonly IStudentRepository _bookRepository;

        public StudentsHomeVorkController(IStudentRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        //////////////////////////////////StudentsHomeVork
        
        [HttpGet]
        public async Task<IEnumerable<StudentsHomeVork>> StudentsHomeVork_Book()
        {
            return await _bookRepository.StudentsHomeVork_Book();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentsHomeVork>> StudentsHomeVork_book(int id)
        {
            return await _bookRepository.StudentsHomeVork_book(id);
        }

        [HttpPost]
        public async Task<ActionResult<StudentsHomeVork>> Create_StudentsHomeVork([FromBody] StudentsHomeVork StudentsHomeVork_book)
        {
            var newBook = await _bookRepository.Create_StudentsHomeVork(StudentsHomeVork_book);
            return CreatedAtAction(nameof(StudentsHomeVork_Book), new { id = newBook.ID }, newBook);
        }

        [HttpPut]
        public async Task<ActionResult> Update_StudentsHomeVork(int id, [FromBody] StudentsHomeVork StudentsHomeVork_book)
        {
            if (id != StudentsHomeVork_book.ID)
            {
                return BadRequest();
            }

            await _bookRepository.Update_StudentsHomeVork(StudentsHomeVork_book);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete_StudentsHomeVork(int id)
        {
            var bookToDelete = await _bookRepository.StudentsHomeVork_book(id);
            if (bookToDelete == null)
                return NotFound();

            await _bookRepository.Delete_StudentsHomeVork(bookToDelete.ID);
            return NoContent();
        }
    }
}
