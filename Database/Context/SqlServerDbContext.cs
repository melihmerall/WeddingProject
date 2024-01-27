using Microsoft.EntityFrameworkCore;
using System;
using WeddingProject.Controllers;
using WeddingProject.Entities;

namespace WeddingProject.Database.Context
{
    public class SqlServerDbContext: DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        {
        }

        // DbSet tanımlamalarınızı ekleyin
        public DbSet<AboutPage> AboutPages{ get; set; }
        public DbSet<ContactPage> ContactPages{ get; set; }
        public DbSet<HomePage> HomePages{ get; set; }


    }
}
