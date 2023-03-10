// 1. Using to work with EntityFramework
using Microsoft.EntityFrameworkCore;
using UniApiBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// 2. Conecction with SQL server express
const string CONECCTIONNAME = "UniversityDB";
var conecctionString = builder.Configuration.GetConnectionString(CONECCTIONNAME);

// 3. Add context to services of builder
builder.Services.AddDbContext<UniversityContext>(Options => Options.UseSqlServer(conecctionString));


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

app.UseAuthorization();

app.MapControllers();

app.Run();
