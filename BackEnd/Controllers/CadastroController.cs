using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BackEnd.ContractService;
using BackEnd.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CadastroController : ControllerBase
  {
    private readonly ICadastroService _cadastroService;
    private readonly IMapper _mapper;

    public CadastroController(ICadastroService cadastroService, IMapper mapper)
    {
      _cadastroService = cadastroService ?? throw new ArgumentNullException(nameof(cadastroService));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<CadastroViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllAsync()
    {
      var cadastro = await _cadastroService.ListCadastroGrid();
      var cadastroViewModels = _mapper.Map<IEnumerable<CadastroViewModel>>(cadastro);

      return Ok(cadastroViewModels);
    }


  }
}
