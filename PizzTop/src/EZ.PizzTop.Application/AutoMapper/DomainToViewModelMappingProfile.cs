using AutoMapper;
using EZ.PizzTop.Application.ViewModels;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();

            // ..mapear todos os demais viewModels
        }
    }
}