using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using MtFit_API.Database;
using MyFit_API;
using MyFit_API.Controllers;
using MyFit_API.Repositories;
using MyFit_API.Services;
using System.Web.Http.Cors;

var builder = WebApplication.CreateBuilder(args);

/*
 *          Services / Repository & Controllers registration
 */

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

new SwaggerControllerSingletonRegistrator(builder);

/*
 *          CORS Policy
 *          https://learn.microsoft.com/it-it/aspnet/core/security/cors?view=aspnetcore-7.0
 */

builder.Services.AddCors();

/*
 *          Database Connector
 */

string connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");
DatabaseInfo.ConnectionString = connectionString;

//Builder
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
