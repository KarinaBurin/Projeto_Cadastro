using BackEnd.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.ContractRepository
{
  public interface ICadastroRepository
  {
    Task<IEnumerable<Cadastro>> ListCadastroGrid();
    
  }
}
