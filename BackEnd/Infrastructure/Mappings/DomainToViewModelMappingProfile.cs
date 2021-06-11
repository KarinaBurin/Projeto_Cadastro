using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BackEnd.Entitie;
using BackEnd.ViewModel;

namespace BackEnd.Infrastructure.Mappings
{
  public class DomainToViewModelMappingProfile : Profile
  {
    public DomainToViewModelMappingProfile()
    {
      CreateMap<Cadastro, CadastroViewModel>().ReverseMap();
    }
  }
}
