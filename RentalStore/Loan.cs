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

        //once a movie is overdue the colour will be red
        public string Colour
        {
            get
            {
                if (this.IsOverdue())
                    return "Red";
                else
                    return "Black";
            }
        }

        public Loan()
        {

        }
        public Loan(Movie myMovie, int days)
        {
            MyMovie = myMovie;
            Days = days;
            DateReturn();
            Cost();
        }

        //get a return date based upon how many days the movie is rented for
        public void DateReturn()
        {
            ReturnDate = DateTime.Now.AddDays(Days);
        }

        //if the movie is overdue the method will return true
        public bool IsOverdue()
        {
            DateTime example = new DateTime(2019, 12, 01);
            if (DateTime.Now > ReturnDate)
            {
                return true;
            }
            else
                return false;
        }

        //getting the cost of each loan for how many days the movie is rented out for
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
