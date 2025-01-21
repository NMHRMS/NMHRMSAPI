using Application.AppStart;
using Application.Mapper;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Add CORS with a policy to allow all origins, headers, and methods
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.AllowAnyOrigin()  // Allows all origins
                   .AllowAnyHeader()  // Allows all headers
                   .AllowAnyMethod(); // Allows all methods (GET, POST, etc.)
        });
});

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HrmsDatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("Sql")));

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

var secretKey = configuration.GetSection("AppSettings:JwtSecret").Value;
var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = false,
            ValidateAudience = false,
            IssuerSigningKey = key
        };
    });

builder.Services.AddAuthorization(options =>
{
    // Set a default authorization policy for all controllers
    options.FallbackPolicy = options.DefaultPolicy;
});

builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
