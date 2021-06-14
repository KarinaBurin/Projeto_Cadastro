using BackEnd.Entitie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEnd.ContractRepository
{
  public interface ICadastroRepository
  {
    Task<IEnumerable<Cadastro>> ListCadastroGrid();
    Task CreateCadastro(string tabParametros);
    Task DeleteCadastro(int id);
  }
}
