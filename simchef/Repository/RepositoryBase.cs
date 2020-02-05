using System;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using simchef.DataAcess;
using simchef.Models.Base;


namespace simchef.Repository
{
  public class RepositoryBase<T> : IRepository<T> where T : ModelBase
  {
    private readonly ConectionContest _conection;
    private DbSet<T> dataSet;

    public RepositoryBase(ConectionContest conection)
    {
      _conection = conection;
      dataSet = _conection.Set<T>();
    }

    public bool Delete(T obj)
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


    public bool Update(T obj)
    {
      throw new System.NotImplementedException();
    }

    public Task<bool> Insert(T obj)
    {
      try
      {
        dataSet.Add(obj);
        int resp = _conection.SaveChanges();
        return Task.FromResult(true);
      }
      catch (System.Exception)
      {
        return Task.FromResult(false);
      }
    }
  }
}