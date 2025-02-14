using Microsoft.EntityFrameworkCore;
using Final_Project.Models;
using System.Collections.Generic;

namespace Final_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<FormModel> Forms { get; set; }
    }
}