using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using simchef.Models.Base;
using simchef.Repository;

namespace simchef.Models

{
  public class UrlNotaViewModel
  {
    public UrlNota urlNota { get; set; }
    public Produtos produtos { get; set; }


    private readonly IRepository<UrlNota> _repositoryUrl;
    private readonly IRepository<Produtos> _repositoryProdutos;

    public UrlNotaViewModel(IRepository<UrlNota> repositoryUrl, IRepository<Produtos> repositoryProdutos)
    {
      _repositoryUrl = repositoryUrl;
      _repositoryProdutos = repositoryProdutos;
    }

    public bool AddUrlNota(){
      return true;
    }

  }
}
