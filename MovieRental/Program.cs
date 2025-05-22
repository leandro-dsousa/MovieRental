using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Application.Interfaces.Services;
using MovieRental.Application.Services.Movies;
using MovieRental.Application.Services.Rentals;
using MovieRental.Infrastructure;
using MovieRental.Infrastructure.Repositories.Movies;
using MovieRental.Infrastructure.Repositories.Rentals;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkSqlite().AddDbContext<MovieRentalDbContext>();

builder.Services.AddScoped<IRentalRepository, RentalRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddScoped<IRentalService, RentalService>();
builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var client = new MovieRentalDbContext())
{
	client.Database.EnsureCreated();
}

app.Run();
