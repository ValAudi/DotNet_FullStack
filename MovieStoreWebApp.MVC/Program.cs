using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Infrastructure.Repository;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MovieStoreContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("MovieStore"));
});

// Add services
builder.Services.AddScoped<ITrailerService, TrailerService>();
builder.Services.AddScoped<ICastService, CastService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IPurchaseService, PurchaseService>();
builder.Services.AddScoped<IMovieUserService, MovieUserService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped<IRoleService, RoleService>();

//Add Repository
builder.Services.AddScoped<ITrailerRepository, TrailerRepository>();
builder.Services.AddScoped<ICastRepository, CastRepository>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();
builder.Services.AddScoped<IMovieUserRepository, MovieUserRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
