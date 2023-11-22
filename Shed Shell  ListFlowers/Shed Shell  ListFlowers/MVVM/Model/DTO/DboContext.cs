using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Shed_Shell__ListFlowers.DTO
{
    public class DboContext : DbContext
    {
        public string filepath;
        public DbSet<Flower> Flower { get; set; }
        public DbSet<CategoryFlower> Categories { get;  set; }

        public DboContext(string filepath)
        {
            this.filepath = filepath;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={filepath}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
