using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using simchef.Models.Base;

namespace simchef.Models

{
public class UrlNota:ModelBase
{
  public string id_nota { get; set; }

  [Required]
  public string url_nota { get; set; }

  public DateTime data_cadastro { get; set; }

  public DateTime data_compra { get; set; }
}
}