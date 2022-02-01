using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("pet")]
    public class Pet : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("raca")]
        public string Raca { get; set; }

        [Column("idade")]
        public string Idade { get; set; }
    }
}
