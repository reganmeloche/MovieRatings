using System;

namespace MovieRatingsLib
{
    public class Rating
    {
        public DateTime RatingDate { get; }
        public int  Value { get; }
        public string Review { get; }
        public string Username { get; }

        public Rating(int value, string review, string username) {
            if (value < 1 || value > 5) {
                throw new Exception($"Invalid rating value {value}");
            }

            RatingDate = DateTime.Now;
            Value = value;
            Username = username;
            Review = review;
        }
    }
}
