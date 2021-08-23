using Funcional.Tech.Api.Interfaces;
using System;

namespace Funcional.Tech.Api.Models
{
    public abstract class BaseEntity : IEntity
    {
        public int id { get; set; }
        public int conta { get; set; }
        public DateTime? data_criacao { get; set; }

    }
}
