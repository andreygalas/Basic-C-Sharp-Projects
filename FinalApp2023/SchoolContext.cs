using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalChallengeAssignment;
using Microsoft.EntityFrameworkCore;

namespace FinalChallangeAssignment
{
    class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}