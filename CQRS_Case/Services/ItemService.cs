using CQRS_Case.Commands;
using CQRS_Case.Models;
using CQRS_Case.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Case.Services
{
    internal class ItemService : IItemService
    {
        private readonly IRepository<Item> _repository;

        public ItemService(IRepository<Item> repository)
        {
            _repository = repository;
        }
        public void Add(Item entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
