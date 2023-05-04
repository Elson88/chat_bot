using API_chat_postgreSQL.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.RateLimiting;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ConnectionPostgreSQL = builder.Configuration.GetConnectionString("ConnectionPostgreSQL");
builder.Services.AddDbContext<API_chat_postgreSQLDBContext>(option => option.UseNpgsql(
    ConnectionPostgreSQL));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddAuthentication()
//    .AddJwtBearer();


//builder.Services.AddDbContext<API_chat_postgreSQLDBContext>();
builder.Services.ConfigureSwaggerGen(setup =>
{
    setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Weather Forecasts",
        Version = "v1"
    });
});

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
