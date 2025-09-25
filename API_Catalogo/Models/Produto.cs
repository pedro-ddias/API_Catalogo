namespace API_Catalogo.Models;

public class Produto
{
    //Chave primária por convenção
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public string? ImagemUrl { get; set; }
    public int Estoque { get; set; }

    // Chave estrangeira por convenção
    public int CatoriaId { get; set; }
    // Propriedade de navegação
    public Categoria? Categoria { get; set; }
}
