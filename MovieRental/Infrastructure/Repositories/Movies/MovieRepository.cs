﻿using Microsoft.EntityFrameworkCore;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Infrastructure.Repositories.Movies
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieRentalDbContext _movieRentalDb;
        public MovieRepository(MovieRentalDbContext movieRentalDb)
        {
            _movieRentalDb = movieRentalDb;
        }

        public async Task<Movie> Save(Movie movie)
        {
            await _movieRentalDb.Movies.AddAsync(movie);
            _movieRentalDb.SaveChanges();
            return movie;
        }

        // TODO: tell us what is wrong in this method? Forget about the async, what other concerns do you have?
        // As No Trackings
        public Task<List<Movie>> GetAll(bool tracking)
        {
            return tracking ? 
                _movieRentalDb.Movies.ToListAsync() :
                _movieRentalDb.Movies
                .AsNoTracking()
                .ToListAsync();
        }


    }
}
