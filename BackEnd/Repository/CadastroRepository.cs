using BackEnd.ContractRepository;
using BackEnd.Entitie;
using BackEnd.Helpers;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackEnd.Repository
{
  public class CadastroRepository : BaseDapper, ICadastroRepository
  {
    public CadastroRepository(SettingsApplication configuration) : base(configuration)
    {}

    public async Task<IEnumerable<Cadastro>> ListCadastroGrid()
    {
      return await QueryAsync<Cadastro>("spsCadastroGrid");
    }

  }
}
