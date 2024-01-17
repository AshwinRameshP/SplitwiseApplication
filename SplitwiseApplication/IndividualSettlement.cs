using SplitwiseApplication.Interface;
using SplitwiseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication
{
    internal class IndividualSettlement :ISettlement
    {
        private User debtor;
        private User creditor;
        private double amount;

        public IndividualSettlement(User debtor, User creditor, double amount)
        {
            this.debtor = debtor;
            this.creditor = creditor;
            this.amount = amount;
        }
        public User getDebtor()
        {
            return debtor;
        }
        public User getCreditor()
        {
            return creditor;
        }
        public double getAmount()
        {
            return amount;
        }
    }
}
