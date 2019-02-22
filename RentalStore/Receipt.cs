using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    public class Receipt
    {
        public List<Loan> MyLoans { get; set; }
        public decimal TotalCost { get; set; }
    }
}
