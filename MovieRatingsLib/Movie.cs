using System;
using System.Collections.Generic;

namespace MovieRatingsLib
{
    public class Movie
    {
        public Guid Id { get; }
        public string Title { get; }
        public string Director { get; }
        public int Year { get; }
        public List<string> Genres { get; }
        List<Rating> _ratings;

        public double AverageRating {
            get {
                if (_ratings.Count == 0) {
                    return 0;
                }
                double sum = 0;
                foreach (var rating in _ratings) {
                    sum += rating.Value;
                }
                return Math.Round(sum / _ratings.Count, 2);
            }
        }

        public Movie(string title, string director, int year, List<string> genres) {
            if (year < 1900 || year > DateTime.Now.Year + 1) {
                throw new Exception($"Invalid year entered {year}");
            }

            Id = Guid.NewGuid();
            Title = title;
            Director = director;
            Year = year;
            Genres = genres; // should copy...
            _ratings = new List<Rating>();
        }

        internal void Rate(Rating rating) {
            _ratings.Add(rating);
        }

        public override string ToString() {
            return $"-- {Id}: {Title} ({Year}) by {Director}: {AverageRating}";
        } 
    }
}
