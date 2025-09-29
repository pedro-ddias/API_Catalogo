using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Catalogo.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        // Construtor para inicializar a coleção de produtos
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        //Chave primária por convenção
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }

        // Relação 1 para muitos (uma categoria para muitos produtos)
        public ICollection<Produto>? Produtos { get; set; }
    }
}
