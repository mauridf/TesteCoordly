using System.ComponentModel.DataAnnotations;

namespace TesteCoordly.Model;

public class Produto
{
    public int ProdutoID { get; set; }

    [Required(ErrorMessage = "O nome do produto é requerido")]
    public string Nome { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "Preço deve ser maior do que 0")]
    public decimal Preco { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "O estoque deve possuir quantidade igual ou maior que 0")]
    public int QuantidadeEstoque { get; set; }
}
