using System.Collections;
using simchef.Models;

namespace simchef.Repository
{
  public interface IRepositoryUrlNota
  {
        IEnumerable GetAll();
    IEnumerable GetId(int id);
    bool Insert(UrlNota obj);
    bool Update(UrlNota obj);
    bool Delete(UrlNota obj);
  }
}