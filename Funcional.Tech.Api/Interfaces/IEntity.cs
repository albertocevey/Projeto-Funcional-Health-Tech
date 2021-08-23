using System;

namespace Funcional.Tech.Api.Interfaces
{
    public interface IEntity
    {
        int conta { get; set; }
        DateTime? data_criacao { get; set; }
    }
}
