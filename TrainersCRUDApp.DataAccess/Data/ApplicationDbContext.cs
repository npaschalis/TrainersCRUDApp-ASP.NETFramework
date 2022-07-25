using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrainersCRUDApp.Models;

namespace TrainersCRUDApp.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Trainer> Trainers { get; set; }
    }
}