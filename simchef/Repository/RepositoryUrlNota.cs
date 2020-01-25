using System.Collections;
using simchef.DataAcess;
using simchef.Models;

namespace simchef.Repository
{
  public class RepositoryUrlNota: IRepositoryUrlNota
  {
    private IRepository<UrlNota> _repository;
    public RepositoryUrlNota(IRepository<UrlNota> reposyitory)
    {
      _repository = reposyitory;
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
      return _repository.Insert(obj);
    }

    public bool Update(UrlNota obj)
    {
      throw new System.NotImplementedException();
    }
  }
}

