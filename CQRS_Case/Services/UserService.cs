using CQRS_Case.Models;
using CQRS_Case.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Case.Services
{
    public class UserService
    {
        private readonly IRepository<UserModel> userRepository;

        public UserService(IRepository<UserModel> userRepository)
        {
            this.userRepository = userRepository;
        }

        public void CreateUser(UserModel user)
        {
            userRepository.Create(user);
        }

        public void UpdateUser(int id, UserModel user)
        {
            userRepository.Update(id, user);
        }

        public void DeleteUser(int id)
        {
            userRepository.Delete(id);
        }

        public UserModel GetUser(int id)
        {
            return userRepository.GetById(id);
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            return userRepository.GetAll();
        }
    }
}
