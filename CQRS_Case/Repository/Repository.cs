using CQRS_Case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Case.Repository
{
    public class UserRepository : IRepository<UserModel>
    {
        private readonly List<UserModel> users = new List<UserModel>();
        public void Create(UserModel model)
        {
            users.Add(model);
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            users.Remove(user);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return users;
        }

        public UserModel GetById(int id)
        {
            return users.Find(u => u.Id == id);
        }

        public void Update(int id, UserModel model)
        {
            var user = GetById(id);
            users.Remove(user);
            users.Add(model);
        }
    }
}
