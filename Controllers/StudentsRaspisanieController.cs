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
    public class StudentsRaspisanieController : Controller
    {
        private readonly IStudentRepository _bookRepository;

        public StudentsRaspisanieController(IStudentRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        /////////////////////////////////////StudentsRaspisanie
        
        [HttpGet]
        public async Task<IEnumerable<StudentsRaspisanie>> Raspisanie_Book()
        {
            return await _bookRepository.StudentsRaspisanie_Book();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentsRaspisanie>> Raspisanie_Book(int id)
        {
            return await _bookRepository.StudentsRaspisanie_book(id);
        }
        
        [HttpPost]
        public async Task<ActionResult<StudentsRaspisanie>> Create_StudentsRaspisanie([FromBody] StudentsRaspisanie StudentsRaspisanie_book)
        {
            var newBook = await _bookRepository.Create_StudentsRaspisanie(StudentsRaspisanie_book);
            return CreatedAtAction(nameof(Raspisanie_Book), new { id = newBook.ID }, newBook);
        }
        
        [HttpPut]
        public async Task<ActionResult> Update_StudentsRaspisanie(int id, [FromBody] StudentsRaspisanie StudentsRaspisanie_book)
        {
            if (id != StudentsRaspisanie_book.ID)
            {
                return BadRequest();
            }

            await _bookRepository.Update_StudentsRaspisanie(StudentsRaspisanie_book);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete_StudentsRaspisanie(int id)
        {
            var bookToDelete = await _bookRepository.StudentsRaspisanie_book(id);
            if (bookToDelete == null)
                return NotFound();

            await _bookRepository.Delete_StudentsRaspisanie(bookToDelete.ID);
            return NoContent();
        }
    }
}
