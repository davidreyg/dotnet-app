using DE.Api.Extensions;
using DE.Application;
using DE.Infrastructure;
using DE.Infrastructure.Data.Contexts;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var cors = "AllowAll";

builder.Services.AddControllers();

// Configure Infisical First (antes de todo)
// This will load secrets and make available in builder.Configuration
builder.AddInfisicalConfiguration();
builder.AddOpenApiDocumentation();

// Add Infrastructure (Authentication)
builder.Services.AddAuthInfrastructure(builder.Configuration);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();

builder.Services.AddInjectionApplication();
builder.Services.AddInjectionInfrastructure(builder.Configuration);
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: cors,
        builder =>
        {
            builder.WithOrigins("*");
            builder.AllowAnyMethod();
            builder.AllowAnyHeader();
        }
    );
});

var app = builder.Build();
app.UseCors(cors);

// Configure the HTTP request pipeline
app.UseOpenApiDocumentation();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var initializer =
            scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitializer>();
        await initializer.InitializeAsync();
        await initializer.SeedAsync();
    }
}

// app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
