using SplitwiseApplication.Interface;
using SplitwiseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication.Expense
{
    internal class GroupExpense : IExpense
    {
        private User payer;
        private double amount;
        private List<User> participants;
        public GroupExpense(User payer, double amount, List<User> participants)
        {
            this.payer = payer;
            this.amount = amount;
            this.participants = participants;
        }

        public User getPayer() { return payer; }
        public double getAmount() { return amount; }
        public List<User> getParticipants() { return participants; }
        public ExpenseType getType()
        {
            return ExpenseType.GROUP;
        }
    }
}
