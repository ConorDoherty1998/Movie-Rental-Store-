using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    public class Customer
    {
        //0 or more receipts per customer
        public List<Receipt> MyReceipts { get; set; } = new List<Receipt>();
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Customer()
        {
            FullName = $"{Firstname} {Lastname}";
        }

        public Customer(string firstname, string lastname, string address, string phoneNumber) : this()
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            PhoneNumber = phoneNumber;
            FullName = $"{Firstname} {Lastname}";
        }
    }
}
