using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    public class Loan
    {
        public List<Movie> MyMovies { get; set; } = new List<Movie>();
        public int Days { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal Price { get; set; }

        public Loan()
        {

        }
        public Loan(List<Movie> myMovies, int days)
        {
            MyMovies = myMovies;
            Days = days;
        }

        public void DateReturn()
        {
            ReturnDate = DateTime.Now.AddDays(Days);
        }

        public void Cost()
        {
            decimal price = 0;

            foreach (Movie movie in MyMovies)
            {
                price += movie.PricePerDay * Days;
            }

            Price = price;
        }
    }
}
