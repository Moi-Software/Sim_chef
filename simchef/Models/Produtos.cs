using System;
using simchef.Models.Base;

namespace simchef.Models
{
  public class Produtos : ModelBase
  {
    public string name_prod { get; set; }
    public float qtd_prod { get; set; }
    public int id_urNota { get; set; }
    
  }
}