using SplitwiseApplication.Expense;
using SplitwiseApplication.Interface;
using SplitwiseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication
{
    internal class ExpenseFactory
    {
        public static IExpense CreateExpense(User payer, double amount, List<User>? participants) { 
            if(participants == null || participants.Count== 0) 
                return new IndividualExpense(payer, amount);
            else
                return new GroupExpense(payer, amount, participants);
        }
    }
}
