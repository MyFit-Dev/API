using MtFit_API.Database;
using MyFit_API.Controllers;
using MyFit_API.Repositories;
using MyFit_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<UserController, UserController>();
builder.Services.AddSingleton<UserService, UserService>();
builder.Services.AddSingleton<UserRepository, UserRepository>();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");
DatabaseInfo.ConnectionString = connectionString;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
