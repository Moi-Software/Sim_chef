using System.Collections;

namespace simchef.Repository
{
  interface IRepository<T>
  {
    IEnumerable GetAll();
    IEnumerable GetId(int id);
    bool Insert(T obj);
    bool Update(T obj);
    bool Delete(T obj);
  }
}
