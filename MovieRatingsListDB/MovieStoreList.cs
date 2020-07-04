using System;
using System.Collections.Generic;
using System.Linq;
using MovieRatingsLib;

namespace MovieRatingsListDB
{
    public class MovieStoreList : IStoreMovies
    {
        List<Movie> _movieList;

        public MovieStoreList() {
            _movieList = new List<Movie>();
        }

        public void Save(Movie movie) {
            _movieList.Add(movie);
        }

        public Movie Get(Guid id) {
            return _movieList.FirstOrDefault(x => x.Id == id);
        }

        public List<Movie> GetAll() {
            return _movieList; // TODO: Should send a copy...
        }
    }
}
