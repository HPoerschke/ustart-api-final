using System;
using UStart.Domain.Commands;

namespace UStart.Domain.Entities
{
    public class GrupoProduto
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public string CodigoExterno { get; private set; }

        public GrupoProduto()
        {            
        }

        //TODO: Refatorar a duplicação de código.
        public GrupoProduto(GrupoProdutoCommand command)
        {
            Id = command.Id == Guid.Empty ? Guid.NewGuid() : command.Id;            
            this.Descricao = command.Descricao;
            this.CodigoExterno = command.CodigoExterno;
        }

        //TODO: Refatorar a duplicação de código.
        public void Update(GrupoProdutoCommand command)
        {
            this.Descricao = command.Descricao;
            this.CodigoExterno = command.CodigoExterno;
        }

        
        
    }
}