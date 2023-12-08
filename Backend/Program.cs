using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TraininggSystem.Data;
//using TraininggSystem.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TraininggSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TraininggSystemContext") ?? throw new InvalidOperationException("Connection string 'TraininggSystemContext' not found.")));
//builder.Services.AddDbContext<TraininggSystemContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("TraininggSystemContext") ?? throw new InvalidOperationException("Connection string 'TraininggSystemContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(options =>
options.WithOrigins("http://localhost:4200")
.AllowAnyMethod()
.AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
