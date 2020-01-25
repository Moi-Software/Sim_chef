using System;
using Microsoft.AspNetCore.Mvc;
using simchef.Models.Base;

namespace simchef.Models

{
public class UrlNota:ModelBase
{
  public string url_nota { get; set; }
  public DateTime data_cadastro { get; set; }
}
}