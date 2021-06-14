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

    [HttpGet("Grid", Name = nameof(GetAllAsync))]
    [ProducesResponseType(typeof(IEnumerable<CadastroViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllAsync()
    {
      var cadastro = await _cadastroService.ListCadastroGrid();
      var cadastroViewModels = _mapper.Map<IEnumerable<CadastroViewModel>>(cadastro);

      return Ok(cadastroViewModels);
    }

    [HttpPost]
    [ProducesResponseType(typeof(CadastroViewModel), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateAsync([FromBody] ParametrosCadastroViewModel ParametroviewModel)
    {
      var tabParametroJson = ParametroviewModel.ConvertModelToJSONCreate();
      await _cadastroService.CreateCadastro(tabParametroJson);


      return CreatedAtRoute(nameof(GetAllAsync), ParametroviewModel);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteAsync([FromRoute] int id)
    {
      await _cadastroService.DeleteCadastro(id);
      return NoContent();
    }

  }
}
