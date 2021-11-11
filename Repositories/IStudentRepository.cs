
using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public interface IStudentRepository
    {
        ///Student
        Task<IEnumerable<Student>> Get();
        Task<Student> Get(int id);
        Task<Student> Create(Student book);
        Task Update(Student book);
        Task Delete(int id);
        //////////////////////////////////GROUP_STUDENT
        Task<IEnumerable<GROUP_STUDENT>> Get_GROUP_Book();
        Task<GROUP_STUDENT> Get_GROUP_book(int id);
        Task<GROUP_STUDENT> Create_Group(GROUP_STUDENT GROUP_book);
        Task Update_Group(GROUP_STUDENT GROUP_book);
        Task Delete_Group(int id);
        //////////////////////////////////StudentsHomeVork
        Task<IEnumerable<StudentsHomeVork>> StudentsHomeVork_Book();
        Task<StudentsHomeVork> StudentsHomeVork_book(int id);
        Task<StudentsHomeVork> Create_StudentsHomeVork(StudentsHomeVork StudentsHomeVork_book);
        Task Update_StudentsHomeVork(StudentsHomeVork StudentsHomeVork_book);
        Task Delete_StudentsHomeVork(int id);
        //////////////////////////////////StudentsRaspisanie
        Task<IEnumerable<StudentsRaspisanie>> StudentsRaspisanie_Book();
        Task<StudentsRaspisanie> StudentsRaspisanie_book(int id);
        Task<StudentsRaspisanie> Create_StudentsRaspisanie(StudentsRaspisanie StudentsRaspisanie_book);
        Task Update_StudentsRaspisanie(StudentsRaspisanie StudentsRaspisanie_book);
        Task Delete_StudentsRaspisanie(int id);
    }
}
