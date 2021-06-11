using BackEnd.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ContractService
{
  public interface ICadastroService
  {
    Task<IEnumerable<Cadastro>> ListCadastroGrid();
  }
}
