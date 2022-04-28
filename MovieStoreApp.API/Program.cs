using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Infrastructure.Repository;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Repository
builder.Services.AddScoped<ITrailerServiceAsync, TrailerServiceAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
builder.Services.AddScoped<IReviewServiceAsync, ReviewServiceAsync>();
builder.Services.AddScoped<IPurchaseServiceAsync, PurchaseServiceAsync>();
builder.Services.AddScoped<IMovieUserServiceAsync, MovieUserServiceAsync>();
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();
builder.Services.AddScoped<IGenreServiceAsync, GenreServiceAsync>();
builder.Services.AddScoped<IRoleServiceAsync, RoleServiceAsync>();

//Add Repository
builder.Services.AddScoped<ITrailerRepositoryAsync, TrailerRepositoryAsync>();
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<IGenreRepositoryAsync, GenreRepositoryAsync>();
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<IPurchaseRepositoryAsync, PurchaseRepositoryAsync>();
builder.Services.AddScoped<IMovieUserRepositoryAsync, MovieUserRepositoryAsync>();
builder.Services.AddScoped<IReviewRepositoryAsync, ReviewRepositoryAsync>();
builder.Services.AddScoped<IRoleRepositoryAsync, RoleRepositoryAsync>();


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
