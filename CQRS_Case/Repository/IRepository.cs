using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Case.Repository
{
    public interface IRepository<TModel> where TModel : class
    {
        void Create(TModel model);
        void Update(int id, TModel model);
        void Delete(int id);
        TModel GetById(int id);
        IEnumerable<TModel> GetAll();
    }
}
