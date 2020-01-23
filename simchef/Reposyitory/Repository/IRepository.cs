using System;
using Microsoft.AspNetCore.Mvc;

namespace simchef.Repository
{
public Interface IRepository<T> : class
{
IEnumerable Get_all();
IEnumerable Get_id(int id);
bool Insert(T obj);
bool Update(T obj);
bool Delete(T obj);
}
}
