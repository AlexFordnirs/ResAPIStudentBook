﻿using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Student> Books { get; set; }
    }
}
