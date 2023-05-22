using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using MtFit_API.Database;
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


builder.Services.AddSingleton<UserController, UserController>();
builder.Services.AddSingleton<UserService, UserService>();
builder.Services.AddSingleton<UserRepository, UserRepository>();

builder.Services.AddSingleton<PlanController, PlanController>();
builder.Services.AddSingleton<PlanService, PlanService>();
builder.Services.AddSingleton<PlanRepository, PlanRepository>();

builder.Services.AddSingleton<DietController, DietController>();
builder.Services.AddSingleton<DietService, DietService>();
builder.Services.AddSingleton<DietRepository, DietRepository>();

builder.Services.AddSingleton<GymController, GymController>();
builder.Services.AddSingleton<GymService, GymService>();
builder.Services.AddSingleton<GymRepository, GymRepository>();

/*
 *          CORS Policy
 *          https://learn.microsoft.com/it-it/aspnet/core/security/cors?view=aspnetcore-7.0
 */

builder.Services.AddCors(options => {
    options.AddPolicy(name: "DefaulPolicy",
        policy =>
        {
            policy.WithOrigins("*")
                    .WithMethods("*")
                    .WithHeaders("*");
        });

});

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

app.UseCors("DefaulPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
