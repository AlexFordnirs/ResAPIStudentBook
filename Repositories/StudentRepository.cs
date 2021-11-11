
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            _context = context;
        }

        public async Task<Student> Create(Student book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return book;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> Get()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Student> Get(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task Update(Student book)
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        ////////////////////////////////// GROUP_STUDENT
        public async Task<GROUP_STUDENT> Create_Group(GROUP_STUDENT GROUP_book)
        {
            _context.GROUP_STUDENT_Books.Add(GROUP_book);
            await _context.SaveChangesAsync();

            return GROUP_book;
        }

        public async Task Delete_Group(int id)
        {
            var bookToDelete = await _context.GROUP_STUDENT_Books.FindAsync(id);
            _context.GROUP_STUDENT_Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GROUP_STUDENT>> Get_GROUP_Book()
        {
            return await _context.GROUP_STUDENT_Books.ToListAsync();
        }

        public async Task Update_Group(GROUP_STUDENT GROUP_book)
        {
            _context.Entry(GROUP_book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<GROUP_STUDENT> Get_GROUP_book(int id)
        {
            return await _context.GROUP_STUDENT_Books.FindAsync(id);
        }


        //////////////////////////////////StudentsHomeVork
        public async Task<IEnumerable<StudentsHomeVork>> StudentsHomeVork_Book()
        {
            return await _context.StudentsHomeVork_Books.ToListAsync();
        }

        public async Task<StudentsHomeVork> StudentsHomeVork_book(int id)
        {
            return await _context.StudentsHomeVork_Books.FindAsync(id);
        }

        public async Task<StudentsHomeVork> Create_StudentsHomeVork(StudentsHomeVork StudentsHomeVork_book)
        {
            _context.StudentsHomeVork_Books.Add(StudentsHomeVork_book);
            await _context.SaveChangesAsync();

            return StudentsHomeVork_book;
        }

        public async Task Update_StudentsHomeVork(StudentsHomeVork StudentsHomeVork_book)
        {
            _context.Entry(StudentsHomeVork_book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete_StudentsHomeVork(int id)
        {
            var bookToDelete = await _context.StudentsHomeVork_Books.FindAsync(id);
            _context.StudentsHomeVork_Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        //////////////////////////////////StudentsRaspisanie
        public async Task<IEnumerable<StudentsRaspisanie>> StudentsRaspisanie_Book()
        {
            return await _context.StudentsRaspisanie_Books.ToListAsync();
        }

        public async Task<StudentsRaspisanie> StudentsRaspisanie_book(int id)
        {
            return await _context.StudentsRaspisanie_Books.FindAsync(id);
        }

        public async Task<StudentsRaspisanie> Create_StudentsRaspisanie(StudentsRaspisanie StudentsRaspisanie_book)
        {
            _context.StudentsRaspisanie_Books.Add(StudentsRaspisanie_book);
            await _context.SaveChangesAsync();

            return StudentsRaspisanie_book;
        }

        public async Task Update_StudentsRaspisanie(StudentsRaspisanie StudentsRaspisanie_book)
        {
            _context.Entry(StudentsRaspisanie_book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete_StudentsRaspisanie(int id)
        {
            var bookToDelete = await _context.StudentsRaspisanie_Books.FindAsync(id);
            _context.StudentsRaspisanie_Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
