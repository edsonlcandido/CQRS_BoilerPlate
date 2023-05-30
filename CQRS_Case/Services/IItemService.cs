using CQRS_Case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Case.Services
{
    internal interface IItemService
    {
        IEnumerable<Item> GetAll();
        Item GetById(int id);
        void Add(Item entity);
        void Update(Item entity);
        void Delete(int id);
    }
}
