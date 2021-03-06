using System.Collections;
using System.Threading.Tasks;
using simchef.DataAcess;
using simchef.Models;

namespace simchef.Repository
{
  public class RepositoryUrlNota: IRepository<UrlNota>
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

    public async Task<bool> Insert(UrlNota obj)
    {
      var resp = await _repository.Insert(obj);

      var task = Task.FromResult(result: resp);
      return await task;
    }

    public bool Update(UrlNota obj)
    {
      throw new System.NotImplementedException();
    }
  }
}

