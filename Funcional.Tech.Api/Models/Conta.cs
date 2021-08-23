using System.ComponentModel.DataAnnotations.Schema;

namespace Funcional.Tech.Api.Models
{
    [Table("conta", Schema = "contabancaria")]
    public partial class Conta: BaseEntity
    {
        public double saldo { get; set; }
    }
}
