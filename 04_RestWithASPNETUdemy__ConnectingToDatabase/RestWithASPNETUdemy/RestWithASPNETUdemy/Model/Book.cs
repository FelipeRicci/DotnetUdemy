using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("livro")]
        public string Livro { get; set; }

        [Column("autor")]
        public string Autor { get; set; }

        [Column("pagina")]
        public string Pagina { get; set; }
    }
}
