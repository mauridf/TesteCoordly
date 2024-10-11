using Microsoft.EntityFrameworkCore;
using TesteCoordly.Data;
using TesteCoordly.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TesteCoordly.Repository;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> GetProdutosAsync()
    {
        return await _context.Produtos.ToListAsync();
    }

    public async Task<Produto> GetProdutoByIdAsync(int id)
    {
        return await _context.Produtos.FindAsync(id);
    }

    public async Task<Produto> CreateProdutoAsync(Produto produto)
    {
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
        return produto;
    }

    public async Task UpdateProdutoAsync(Produto produto)
    {
        _context.Entry(produto).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProdutoAsync(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto != null)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}
