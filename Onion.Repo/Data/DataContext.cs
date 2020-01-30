using Microsoft.EntityFrameworkCore;
using Onion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Repo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BookMap(modelBuilder.Entity<Book>().ToTable("Books"));
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
    }
}
