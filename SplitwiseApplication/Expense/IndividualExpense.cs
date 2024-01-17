using SplitwiseApplication.Interface;
using SplitwiseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication.Expense
{
    internal class IndividualExpense : IExpense
    {
        private User payer;
        private double amount;
        public IndividualExpense(User payer, double amount) {
            this.payer = payer;
            this.amount = amount;
        }

        public User getPayer() { return payer; }
        public double getAmount() { return amount; }
        public ExpenseType getType()
        {
            return ExpenseType.INDIVIDUAL;
        }
    }
}
