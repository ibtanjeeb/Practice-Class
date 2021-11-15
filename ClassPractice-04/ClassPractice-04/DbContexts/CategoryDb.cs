using ClassPractice_04.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_04.DbContexts
{
   public class CategoryDb:DbContext
    {
        string connectionstring = @"Server= (local);Database=MC; Trusted_Connection=True";

        public DbSet<Category> Categories { get; set; }
        public DbSet<Brands> Brand { get; set; }
        
        public DbSet<Items> Items { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionstring);
        }



    }
}
