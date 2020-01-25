using System.Collections;
using simchef.DataAcess;
using simchef.Models;

namespace simchef.Repository
{
  public class RepositoryUrlNota : IRepository<UrlNota>
  {
    private readonly ConectionContest _conection;

    public RepositoryUrlNota(ConectionContest conection)
    {
      _conection = conection;
    }

    public bool Delete(UrlNota obj)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable GetAll()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable GetId(int id)
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(UrlNota obj)
    {
      using (var conn = _conection)
      {
        conn.Add(obj);
        conn.SaveChanges();
        return true;
      }
    }
    public bool Update(UrlNota obj)
    {
      throw new System.NotImplementedException();
    }
  }
}

