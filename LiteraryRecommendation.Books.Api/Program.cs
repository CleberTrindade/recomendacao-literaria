using LiteraryRecommendation.Books.Api.Configuration;
using LiteraryRecommendation.Api.Core.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerConfiguration();
builder.Services.AddJwtConfiguration(builder.Configuration);
builder.Services.AddApiConfiguration();

var app = builder.Build();

app.UseSwaggerConfiguration();

app.UseApiConfiguration();

app.Run();
