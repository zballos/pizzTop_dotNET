using System;
using System.Collections.Generic;

namespace EZ.PizzTop.Domain.Entities
{
    public class Cliente
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
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        // Navigation property
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        /*
        public bool IsValid()
        {
            ValidationResult = new ClienteEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        pulic ValidationResult ValidationResult { get; set; }
        */
    }
}