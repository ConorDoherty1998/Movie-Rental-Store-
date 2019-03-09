using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    public class Movie
    {
        public string Title { get; set; }
        public int AgeRating { get; set; }
        public decimal PricePerDay { get; set; }
        public int Copies { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
