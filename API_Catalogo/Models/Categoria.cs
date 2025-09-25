using System.Collections.ObjectModel;

namespace API_Catalogo.Models
{
    public class Categoria
    {
        // Construtor para inicializar a coleção de produtos
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        //Chave primária por convenção
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? ImagemUrl { get; set; }

        // Relação 1 para muitos (uma categoria para muitos produtos)
        public ICollection<Produto>? Produtos { get; set; }
    }
}
