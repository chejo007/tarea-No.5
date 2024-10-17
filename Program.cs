using Microsoft.EntityFrameworkCore;
using ApiEmpresa.Models; // Asegúrate de tener el namespace correcto

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<Conexiones>(opt =>
    //opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Solo si estás usando InMemory Database
opt.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiEmpresa v1");
        c.RoutePrefix = string.Empty; // Esto asegurará que Swagger esté en la raíz
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


