using Microsoft.AspNetCore.Mvc;
using TesteCoordly.Model;
using TesteCoordly.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TesteCoordly.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutosController : Controller
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutosController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
    {
        var produtos = await _produtoRepository.GetProdutosAsync();
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Produto>> GetProduto(int id)
    {
        var produto = await _produtoRepository.GetProdutoByIdAsync(id);

        if (produto == null)
        {
            return NotFound();
        }

        return Ok(produto);
    }

    [HttpPost]
    public async Task<ActionResult<Produto>> CreateProduto(Produto produto)
    {
        var createdProduto = await _produtoRepository.CreateProdutoAsync(produto);
        return CreatedAtAction(nameof(GetProduto), new { id = createdProduto.ProdutoID }, createdProduto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduto(int id, Produto produto)
    {
        if (id != produto.ProdutoID)
        {
            return BadRequest();
        }

        await _produtoRepository.UpdateProdutoAsync(produto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduto(int id)
    {
        await _produtoRepository.DeleteProdutoAsync(id);
        return NoContent();
    }
}
