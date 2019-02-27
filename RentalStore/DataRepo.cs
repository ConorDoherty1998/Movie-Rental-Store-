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
            Movie m1 = new Movie() { Title = "Terminator", PricePerDay = 5 };
            Movie m2 = new Movie() { Title = "Avatar", PricePerDay = 3 };
            Movie m3 = new Movie() { Title = "Trainspotting", PricePerDay = 2 };

            List<Movie> moviesCreated = new List<Movie>
            {
                m1,
                m2,
                m3
            };

            return moviesCreated;
        }

        public static void UpdateStockRemove(Movie yourMovie)
        {
            OutOfStock.Add(yourMovie);
            InStock.Remove(yourMovie);
        }

        public static void UpdateStockAdd(Movie yourMovie)
        {
            InStock.Add(yourMovie);
            OutOfStock.Remove(yourMovie);
        }
    }
}
