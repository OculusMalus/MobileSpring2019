using System;

namespace MovieLab
{
    public class Movie
    {
        String name;
        private Rating rating;
        private Genre genre;

        public Movie(String name, Rating rating, Genre genre)
        {
            this.name = name;
            this.rating = rating;
            this.genre = genre;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public Rating getRating()
        {
            return rating;
        }

        public void setRating(Rating rating)
        {
            this.rating = rating;
        }

        public Genre getGenre()
        {
            return genre;
        }

        public void setGenre(Genre genre)
        {
            this.genre = genre;
        }


    public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (!(o.GetType() == typeof(Movie))) {return false;}
            Movie movie = (Movie)o;
            return Objects.Equals(getName(), movie.getName()) &&
                    getRating() == movie.getRating() &&
                    getGenre() == movie.getGenre();
        }


    public int HashCode()
        {
            return Objects.hash(getName(), getRating(), getGenre());
        }


    public String toString()
        {
            return "Movie{" +
                    "name='" + name + '\'' +
                    ", rating=" + rating +
                    ", genre=" + genre +
                    '}';
        }
    }
}

