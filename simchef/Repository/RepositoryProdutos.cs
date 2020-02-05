

using System.Collections;
using System.Threading.Tasks;
using simchef.DataAcess;
using simchef.Models;

namespace simchef.Repository
{


  public class RepositoryProdutos : IRepository<Produtos>
  {

    private IRepository<Produtos> _repository;

    public RepositoryProdutos(IRepository<Produtos> reposyitory)
    {
      _repository = reposyitory;
    }

    public bool Delete(Produtos obj)
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

    public async Task<bool> Insert(Produtos obj)
    {
      var resp = await _repository.Insert(obj);

      var task = Task.FromResult(result: resp);
      return await task;
    }

    public bool Update(Produtos obj)
    {
      throw new System.NotImplementedException();
    }
  }
}