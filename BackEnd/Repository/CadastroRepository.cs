using BackEnd.ContractRepository;
using BackEnd.Entitie;
using BackEnd.Helpers;
using Dapper;
using System.Collections.Generic;
using System.Data;
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
    public async Task CreateCadastro(string tabParametros)
    {
      var parameter = new DynamicParameters();
      parameter.Add("@TabParametrosJson", tabParametros, DbType.String);
      await ExecuteSPAsync("spiCadastro", parameter);
    }

    public async Task DeleteCadastro(int id)
    {
      var parameter = new DynamicParameters();
      parameter.Add("@Id", id, DbType.Int32);
      await ExecuteSPAsync("spdCadastro", parameter);
    }
  }
}
