using ProjectApi.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure DbContext with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("con")));

// Register UnitOfWork
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
// ?? ????? ????? ??????? ??? HTTPS ????? ?????
// app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.Run();
