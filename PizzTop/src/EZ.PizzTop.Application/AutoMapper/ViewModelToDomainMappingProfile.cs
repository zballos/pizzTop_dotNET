using AutoMapper;
using EZ.PizzTop.Application.ViewModels;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();

            // ..mapear todos os demais viewModels
        }
    }
}