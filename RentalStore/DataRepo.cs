using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    public static class DataRepo
    {
        public static List<Movie> InStock { get; set; } = new List<Movie>();
        public static List<Movie> OutOfStock { get; set; } = new List<Movie>();
        public static List<Loan> AllLoans { get; set; } = new List<Loan>();
        public static List<Customer> CurrentCustomers { get; set; } = new List<Customer>();
        public static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer() { Firstname = "Conor" };
            Customer c2 = new Customer() { Firstname = "Bob" };
            Customer c3 = new Customer() { Firstname = "Steve" };

            List<Customer> customersCreated = new List<Customer>
            {
                c1,
                c2,
                c3
            };

            return customersCreated;
        }

        public static List<Movie> GetMovies()
        {
            Movie m1 = new Movie() { Title = "Terminator", PricePerDay = 5, Copies = 3, AgeRating = 18,
            Description = "A seemingly indestructible android is sent from 2029 to 1984 to assassinate a waitress, whose unborn son will lead humanity in a war against the machines, while a soldier from that war is sent to protect her at all costs."};
            Movie m2 = new Movie() { Title = "Avatar", PricePerDay = 3, Copies = 5, AgeRating = 12,
            Description = "A paraplegic marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home."};
            Movie m3 = new Movie() { Title = "Pulp Fiction", PricePerDay = 2, Copies = 2, AgeRating = 18,
            Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption."};
            Movie m4 = new Movie() { Title = "The Good, the Bad and the Ugly", PricePerDay = 4, Copies = 3, AgeRating = 15,
            Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery."};

            List <Movie> moviesCreated = new List<Movie>
            {
                m1,
                m2,
                m3,
                m4
            };

            return moviesCreated;
        }

        public static void UpdateStockRemove(Movie yourMovie)
        {
            Movie tempMovie = new Movie();
            if(!OutOfStock.Contains(yourMovie))
            {
                OutOfStock.Add(yourMovie);
                yourMovie.Copies--;
            }
            else if(yourMovie.Copies == 1)
            {
                InStock.Remove(yourMovie);
                yourMovie.Copies--;
            }
            else
                yourMovie.Copies--;
            //OutOfStock.Add(yourMovie);
            //InStock.Remove(yourMovie);
        }

        public static void UpdateStockAdd(Movie yourMovie)
        {
            if (!InStock.Contains(yourMovie))
            {
                InStock.Add(yourMovie);
                yourMovie.Copies++;
            }
            else if (yourMovie.Copies == 0)
            {
                OutOfStock.Remove(yourMovie);
                yourMovie.Copies++;
            }
            else
                yourMovie.Copies++;
            //InStock.Add(yourMovie);
            //OutOfStock.Remove(yourMovie);
        }
    }
}
