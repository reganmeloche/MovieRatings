using System;
using System.Collections.Generic;

namespace MovieRatingsLib
{
    public interface IStoreMovies {
        Movie Get(Guid id);
        void Save(Movie movie);
        List<Movie> GetAll();
    }
}
