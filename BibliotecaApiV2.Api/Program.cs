using AutoMapper;
using BibliotecaApiV2.Core.Data;
using BibliotecaApiV2.Data;
using BibliotecaApiV2.Data.Repos;
using BibliotecaApiV2.Handlers.MappingProfiles;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
ArgumentNullException.ThrowIfNull(connectionString);

builder.Services.AddDbContext<BibliotecaDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddMediatR([typeof(BibliotecaApiV2.Handlers.DummyMarker).Assembly]);
builder.Services.AddAutoMapper(typeof(AuthorProfile).Assembly);

builder.Services.AddControllers();

builder.Services.AddScoped<IAuthorRepo, AuthorRepo>();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(options =>
{
    var xmlPath = Path.Combine(
        AppContext.BaseDirectory,
        $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");

    options.IncludeXmlComments(xmlPath);
});

var app = builder.Build();
var sp = app.Services.CreateScope().ServiceProvider;
var context = sp.GetService<BibliotecaDbContext>();
var mapper = sp.GetService<IMapper>();
ArgumentNullException.ThrowIfNull(mapper);

mapper.ConfigurationProvider.AssertConfigurationIsValid();

if (context?.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
    context?.Database.Migrate();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
