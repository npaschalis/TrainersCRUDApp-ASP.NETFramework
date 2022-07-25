using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainersCRUDApp.Models;

namespace TrainersCRUDApp.DataAccess.Repository.IRepository
{
    public interface TrainerRepository : IRepository<Trainer>
    {
        void Update(Trainer obj);
    }
}
