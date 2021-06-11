using BackEnd.ContractRepository;
using BackEnd.ContractService;
using BackEnd.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Service
{
  public class CadastroService : ICadastroService
  {
    private readonly ICadastroRepository _cadastroRepository;
    public CadastroService(ICadastroRepository cadastroRepository)
    {
      _cadastroRepository = cadastroRepository ?? throw new ArgumentNullException(nameof(cadastroRepository));
    }

    public async Task<IEnumerable<Cadastro>> ListCadastroGrid()
    {
      return await _cadastroRepository.ListCadastroGrid();
    }
  }
}
