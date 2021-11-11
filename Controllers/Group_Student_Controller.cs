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
    public class Group_Student_Controller : Controller
    {
        private readonly IStudentRepository _bookRepository;

        public Group_Student_Controller(IStudentRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
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
        public async Task<ActionResult<GROUP_STUDENT>> Post_Create_Group([FromBody] GROUP_STUDENT GROUP_book)
        {
            var newBook = await _bookRepository.Create_Group(GROUP_book);
            return CreatedAtAction(nameof(Get_GROUP), new { id = newBook.ID }, newBook);
        }

        [HttpPut]
        public async Task<ActionResult> Put_Update_Group(int id, [FromBody] GROUP_STUDENT GROUP_book)
        {
            if (id != GROUP_book.ID)
            {
                return BadRequest();
            }

            await _bookRepository.Update_Group(GROUP_book);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var bookToDelete = await _bookRepository.Get_GROUP_book(id);
            if (bookToDelete == null)
                return NotFound();

            await _bookRepository.Delete_Group(bookToDelete.ID);
            return NoContent();
        }
    }
}
