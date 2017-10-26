using System;
using System.Collections.Generic;
using DomainValidation.Interfaces.Validation;
using DomainValidation.Validation;
using EZ.PizzTop.Domain.Validation.Clientes;

namespace EZ.PizzTop.Domain.Entities
{
    public class Cliente : ISelfValidator
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
            Enderecos = new List<Endereco>();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        // Navigation property
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        
        // validator
        public ValidationResult _validationResult;

        ValidationResult ISelfValidator.ValidationResult
        {
            get { return _validationResult; }
        }
        
        public bool IsValid()
        {
            _validationResult = new ClienteEstaConsistenteValidation().Validate(this);
            return _validationResult.IsValid;
        }
    }
}