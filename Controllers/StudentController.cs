
using BookAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _bookRepository;

        public StudentController(IStudentRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        //////////////////////////////////Student
        [HttpGet]
        public async Task<IEnumerable<Student>> GetBooks()
        {
            return await _bookRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetBooks(int id)
        {
            return await _bookRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Student>>PostBooks([FromBody] Student book)
        {
            var newBook = await _bookRepository.Create(book);
            return CreatedAtAction(nameof(GetBooks), new { id = newBook.iD }, newBook);
        }

        [HttpPut]
        public async Task<ActionResult> PutBooks(int id, [FromBody] Student book)
        {
            if(id != book.iD)
            {
                return BadRequest();
            }

            await _bookRepository.Update(book);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id)
        {
            var bookToDelete = await _bookRepository.Get(id);
            if (bookToDelete == null)
                return NotFound();

            await _bookRepository.Delete(bookToDelete.iD);
            return NoContent();
        }


/*
        //////////////////////////////////GROUP_STUDENT
        [HttpGet]
        public async Task<IEnumerable<GROUP_STUDENT>> Get_GROUP()
        {
            return await _bookRepository.Get_GROUP_Book();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GROUP_STUDENT>> Get_GROUP(int id)
        {
            return await _bookRepository.Get_GROUP_book(id);
        }

        [HttpPost]
        public async Task<ActionResult<GROUP_STUDENT>> Create_Group([FromBody] GROUP_STUDENT GROUP_book)
        {
            var newBook = await _bookRepository.Create_Group(GROUP_book);
            return CreatedAtAction(nameof(Get_GROUP_Book), new { id = newBook.ID }, newBook);
        }

        [HttpPut]
        public async Task<ActionResult> Update_Group(int id, [FromBody] GROUP_STUDENT GROUP_book)
        {
            if (id != GROUP_book.ID)
            {
                return BadRequest();
            }

            await _bookRepository.Update_Group(GROUP_book);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete_Group(int id)
        {
            var bookToDelete = await _bookRepository.Get_GROUP_book(id);
            if (bookToDelete == null)
                return NotFound();

            await _bookRepository.Delete_Group(bookToDelete.ID);
            return NoContent();
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

        /////////////////////////////////////StudentsRaspisanie

        [HttpGet]
        public async Task<IEnumerable<StudentsRaspisanie>> StudentsRaspisanie_Book()
        {
            return await _bookRepository.StudentsRaspisanie_Book();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentsRaspisanie>> StudentsRaspisanie_book(int id)
        {
            return await _bookRepository.StudentsRaspisanie_book(id);
        }

        [HttpPost]
        public async Task<ActionResult<StudentsRaspisanie>> Create_StudentsRaspisanie([FromBody] StudentsRaspisanie StudentsRaspisanie_book)
        {
            var newBook = await _bookRepository.Create_StudentsRaspisanie(StudentsRaspisanie_book);
            return CreatedAtAction(nameof(StudentsRaspisanie_Book), new { id = newBook.ID }, newBook);
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
        */
    }
}
