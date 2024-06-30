using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Recycle.Extensions;
using Recycle.Models;
using Recycle.Repositories.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDependencies();

var Configuration = builder.Configuration;
builder.Services.AddDbContext<RecycleContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("RecycleString")));

//var connection = builder.Configuration.GetSection("Connection").Get<ConnectionDto>();
//builder.Services.AddDbContext<RecycleContext>(option => option.UseNpgsql(connection.ConnectionString, o => o.SetPostgresVersion(12, 0)));
//var connection = "Host=localhost;Port=5432;Pooling=true;Database=recycle;User Id=user_db_recycle;Password=pass@ord";
//builder.Services.AddDbContext<RecycleContext>(option => option.UseNpgsql(connection, o => o.SetPostgresVersion(12, 0)));

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
