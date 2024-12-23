using CEDHETEC.LIMPIA.DEMO.PersistenceEFCore;
using CEDHETEC.LIMPIA.DEMO.Presenters;
using CEDHETEC.LIMPIA.DEMO.Controllers;
using CEDHETEC.LIMPIA.DEMO.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddUseCases()
                .AddControllersService()
                .AddPresenters()
                .AddRepositories();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
