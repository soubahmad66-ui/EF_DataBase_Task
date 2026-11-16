using DB_Context_Employee;
using DB_Context_Employee.Interfaces;
using DB_Context_Employee.Repositories;
using EF_DataBase_Task.Middleware;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var config = builder.Configuration;
string? connectionString = config.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IEmployeeRepositories, EmployeeRepositories>();
builder.Services.AddScoped<ICompanyRepositories, CompanyRepositories>();
builder.Services.AddDbContext<App_DBContext_employee>(options => options.UseSqlServer(connectionString));
var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
