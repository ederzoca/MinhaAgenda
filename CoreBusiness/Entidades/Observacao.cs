using SQLite;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness.Entidades
{
    public class Observacao
    {
        public Observacao()
        {
        }

        public Observacao(string? observacao1, string? observacao2)
        {
            Id = Guid.NewGuid();
            Observacao1 = observacao1;
            Observacao2 = observacao2;
        }

        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }

        public string? Observacao1 { get; set; } = string.Empty;
        public string? Observacao2 { get; set; } = string.Empty;
    }
}
