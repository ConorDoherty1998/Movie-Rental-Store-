using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    //acts as a database
    public static class DataRepo
    {
        public static List<Movie> InStock { get; set; } = new List<Movie>();
        public static List<Movie> OutOfStock { get; set; } = new List<Movie>();
        public static List<Loan> AllLoans { get; set; } = new List<Loan>();
        public static List<Customer> CurrentCustomers { get; set; } = new List<Customer>();

        //sample customers
        public static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer("Conor", "Doherty", "Cloone, Co. Leitrim", "087 055 1714");
            Customer c2 = new Customer("Bob", "Marley", "Carrick on Shannon, Co. Leitrim", "087 123 4567");
            Customer c3 = new Customer("Steve", "Bannon", "Manor, Co. Leitrim", "087 987 6543" ) ;
            Customer c4 = new Customer("Brian", "Keaveney", "Arigna, Co. Roscommon", "086 666 6666") ;
            Customer c5 = new Customer("James", "Maguire","Cloone, Co. Leitrim","087 useless" ) ;

            List<Customer> customersCreated = new List<Customer>
            {
                c1,
                c2,
                c3,
                c4,
                c5
            };

            return customersCreated;
        }

        //sample movies
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

        //removing stock from the instock list any time a loan is made
        public static void UpdateStockRemove(Movie yourMovie)
        {
            //if the list out of stock does not contain your movie then add it and take one copie away from stock
            if(!OutOfStock.Contains(yourMovie))
            {
                OutOfStock.Add(yourMovie);
                yourMovie.Copies--;
            }
            else if(yourMovie.Copies == 1) // once your copies is once remove the movie from instock and take a copie away
            {
                InStock.Remove(yourMovie);
                yourMovie.Copies--;
            }
            else //take a copy away any time a loan is added
                yourMovie.Copies--;
        }

        //adding stock to the instock list any time a movie is returned
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
        }
    }
}
