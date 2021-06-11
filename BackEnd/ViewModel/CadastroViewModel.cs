using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ViewModel
{
  public class CadastroViewModel
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public string Rg { get; set; }
    public string CPF { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
  }
}
