using TesteCoordly.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TesteCoordly.Repository;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetProdutosAsync();
    Task<Produto> GetProdutoByIdAsync(int id);
    Task<Produto> CreateProdutoAsync(Produto produto);
    Task UpdateProdutoAsync(Produto produto);
    Task DeleteProdutoAsync(int id);
}
