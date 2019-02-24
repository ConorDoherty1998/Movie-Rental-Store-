using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalStore
{
    public class Receipt
    {
        public List<Loan> MyLoans { get; set; } = new List<Loan>();
        public decimal TotalCost { get; set; }
        public DateTime DateIssued { get; set; }

        public Receipt()
        {

        }

        public Receipt(List<Loan> myLoans, decimal totalCost)
        {
            MyLoans = myLoans;
            TotalCost = totalCost;
            DateIssued = DateTime.Now;
        }

        public override string ToString()
        {
            int count = 0;

            foreach (Loan loan in MyLoans)
            {
                count++;
            }

            return $"Loans: {count}, Date Issued: {DateIssued}, Total Cost: {TotalCost}";
        }
    }
}
