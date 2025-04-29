using WebApi.Models;
using WebApi.Infraestrutura;

var builder = WebApplication.CreateBuilder(args);

// Adicione o serviço de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("MinhaPoliticaCors", policy =>
    {
        policy.WithOrigins("http://127.0.0.1:5500") // <-- seu front-end
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IRepositorioFuncionario, RepositorioFuncionario>();
builder.Services.AddDbContext<ConnectionContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use CORS antes da autorização
app.UseCors("MinhaPoliticaCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
