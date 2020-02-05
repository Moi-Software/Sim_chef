using System.Collections;
using System.Threading.Tasks;
using simchef.Models;

namespace simchef.Repository
{
  public interface IRepository<T>
  {
    IEnumerable GetAll();
    IEnumerable GetId(int id);
   Task<bool> Insert(T obj);
    bool Update(T obj);
    bool Delete(T obj);

  }
}
