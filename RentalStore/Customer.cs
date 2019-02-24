using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    public class Customer
    {
        public List<Receipt> MyReceipts { get; set; } = new List<Receipt>();
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Customer()
        {

        }
    }
}
