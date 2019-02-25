using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    public class Loan
    {
        public Movie MyMovie { get; set; }
        public int Days { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal Price { get; set; }

        public Loan()
        {

        }
        public Loan(Movie myMovie, int days)
        {
            MyMovie = myMovie;
            Days = days;
        }

        public void DateReturn()
        {
            ReturnDate = DateTime.Now.AddDays(Days);
        }

        public void Cost()
        {
            decimal price = 0;

            price = MyMovie.PricePerDay * Days;

            Price = price;
        }

        public override string ToString()
        {
            return $"{MyMovie.Title}, {ReturnDate.ToShortDateString()}, {Price}";
        }
    }
}
