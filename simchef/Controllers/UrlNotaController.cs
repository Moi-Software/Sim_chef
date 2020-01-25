using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using simchef.DataAcess;
using simchef.Models;
using simchef.Repository;

namespace simchef.Controllers
{
  [Route("api_v1/[controller]")]
  [ApiController]
  
  public class UrlNotaController : ControllerBase
  {
    private readonly RepositoryUrlNota _repository;

    public UrlNotaController(RepositoryUrlNota reposyitory)
    {
      _repository = reposyitory;
    }


    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      if (id == 5)
      {
        return "id_5";
      }
      else
      {
        return "value";
      }
    }

    // POST api/values
    [HttpPost]
    public ActionResult<UrlNota> Post(UrlNota urlNota)
    {
      urlNota.data_cadastro = DateTime.Today;
      _repository.Insert(urlNota);
      return CreatedAtAction(nameof(urlNota), urlNota);
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {

    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
