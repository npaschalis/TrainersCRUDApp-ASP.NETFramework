using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainersCRUDApp.DataAccess.Repository.IRepository;
using TrainersCRUDApp.Models;

namespace TrainersCRUDApp.DataAccess.Repository
{
    public class TrainerRepository : Repository<Trainer>, IRepository.TrainerRepository
    {
        private ApplicationDbContext _db;

        public TrainerRepository()
        {
            _db = new ApplicationDbContext();
        }

        public void Update(Trainer obj)
        {
            _db.Trainers.AddOrUpdate(obj);
            _db.SaveChanges();
        }
    }
}
