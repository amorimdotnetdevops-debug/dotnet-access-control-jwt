using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prontuario.Domain.Common.Base
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public DateTime? DataAtualizacao { get; protected set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.UtcNow;
        }

        protected void SetDataAtualizacao()
        {
            DataAtualizacao = DateTime.UtcNow;
        }

        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}
