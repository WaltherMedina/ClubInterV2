using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using ClubInterV2.IOC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*// Value to connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Register service to connection
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);*/


builder.Services.AddAuthorization();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.InyectarDependencias(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy("NuevaPolitica", app => {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();

// Adding UseAuthentication into our pipeline and this should come before UseAuthorization
app.UseAuthentication();

app.UseCors("NuevaPolitica");

app.UseAuthorization();

app.MapControllers();

app.Run();
