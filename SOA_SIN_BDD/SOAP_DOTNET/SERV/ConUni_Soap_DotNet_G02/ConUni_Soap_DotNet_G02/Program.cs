using ConUni_Soap_DotNet_G02.ec.edu.monster.modelo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<Conversión>(); // Añadido para el controlador

var app = builder.Build();

// Activar Swagger SIEMPRE
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
