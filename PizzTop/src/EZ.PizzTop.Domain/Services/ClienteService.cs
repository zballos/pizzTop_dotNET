using System;
using System.Collections.Generic;
using EZ.PizzTop.Domain.Entities;
using EZ.PizzTop.Domain.Interfaces.Repository;
using EZ.PizzTop.Domain.Interfaces.Services;
using EZ.PizzTop.Domain.Validation.Clientes;

namespace EZ.PizzTop.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            if (!cliente.IsValid())
            {
                return cliente;
            }

            var result = new ClienteAptoParaInclusaoValidation(_clienteRepository).Validate(cliente);
            if (!result.IsValid)
            {
                cliente._validationResult = result;
                return cliente;
            }

            _clienteRepository.Adicionar(cliente);

            return cliente;
        }

        public Cliente ObterPorId(Guid id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Atualizar(Cliente cliente)
        {
            _clienteRepository.Atualizar(cliente);
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return _clienteRepository.ObterPorCPF(cpf);
        }

        public Cliente ObterPorTelefone(string telefone)
        {
            return _clienteRepository.ObterPorTelefone(telefone);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _clienteRepository.ObterPorEmail(email);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}