using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabDay3Core.Models
{
    public class ITIContext:DbContext
    {
        public ITIContext(DbContextOptions<ITIContext> options):base(options)
        {

        }
        public virtual DbSet<student> Students { get; set; }
        public virtual DbSet<department> Departments { get; set; }
    }
}
