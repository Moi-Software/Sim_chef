using System;
using Microsoft.AspNetCore.Mvc;

namespace simchef.Repository
{
public Interface IRepository<T> : class
{
ActionResult<T> Get(T t;
ActionResult<T> Post(T t;
ActionResult<T> Put(T t);
ActionResult<T> Delete(T t);
}
}
