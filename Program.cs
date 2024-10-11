using Microsoft.EntityFrameworkCore;
using TesteCoordly.Data;
using TesteCoordly.Repository;
using TesteCoordly.Data;
using TesteCoordly.Repository;

var builder = WebApplication.CreateBuilder(args);

// Configuração do EF Core com SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configuração do Repository
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

// Adicionar serviços do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
