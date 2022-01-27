using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("pet")]
    public class Pet
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("raca")]
        public string Raca { get; set; }

        [Column("idade")]
        public string Idade { get; set; }
    }
}
