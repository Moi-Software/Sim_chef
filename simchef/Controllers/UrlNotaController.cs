using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using simchef.DataAcess;
using simchef.Models;
using simchef.Repository;

namespace simchef.Controllers
{
  [Route("api_v1/[controller]")]
  [ApiController]

  public class UrlNotaController : ControllerBase
  {
    private readonly IRepository<UrlNota> _repositoryUrl;
    private readonly IRepository<Produtos> _repositoryProdutos;

    public UrlNotaController(IRepository<UrlNota> repositoryUrl, IRepository<Produtos> repositoryProdutos)
    {
      _repositoryUrl = repositoryUrl;
      _repositoryProdutos = repositoryProdutos;
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
    public async Task<ActionResult<UrlNota>> Post(UrlNota urlNota)
    {
      urlNota.id = 8;
      urlNota.id_nota = urlNota.url_nota.Split("=")[1].Split("|")[0];

      var client = new RestClient(urlNota.url_nota);
      client.Timeout = -1;
      var request = new RestRequest(Method.GET);
      IRestResponse response = client.Execute(request);
      if (response.IsSuccessful)
      {

        XDocument xDocument = XDocument.Parse(response.Content);

        IEnumerable<XElement> contatos = from c in xDocument.Elements() select c;
        foreach (XElement contato in contatos)
        {

          Console.WriteLine(contato);
        }


        urlNota.data_cadastro = DateTime.Today;
        var retorno = await _repositoryUrl.Insert(urlNota);
        if (retorno == true)
        {
          // return Ok();
          return new ObjectResult(retorno) { StatusCode = 200 };
        }
        else
        {

          return new ObjectResult(retorno) { StatusCode = 500 };
        }
      }
      return CreatedAtAction(nameof(UrlNota), urlNota);
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
