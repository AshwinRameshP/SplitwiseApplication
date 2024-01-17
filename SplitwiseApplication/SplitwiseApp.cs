using SplitwiseApplication.Interface;
using SplitwiseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication
{
    public class SplitwiseApp
    {
        public static void main(String[] args)
        {
            //Creating Users
            User user1 = new User(name: "Ashwin");
            User user2 = new User(name: "Bob");
            User user3 = new User(name: "Aleena");

            //Using Singleton SplitwiseManager to manage expense
            SplitwiseManager splitwiseManager = SplitwiseManager.getInstance();
            SettlementManager settlementManager = SettlementManager.getInstance();

            //Creating Expense
            IExpense expense1 = ExpenseFactory.CreateExpense(user1, amount: 30.0, participants: null);
            IExpense expense2 = ExpenseFactory.CreateExpense(user2, amount: 20.0, participants: null);

            List<User> groupParticipants = new List<User>();
            groupParticipants.Add(user1);
            groupParticipants.Add(user2);
            groupParticipants.Add(user3);

            IExpense expense3 = ExpenseFactory.CreateExpense(user3, amount: 45.0, groupParticipants);

            //Adding expenses to SplitwiseManager
            splitwiseManager.addExpense(expense1);
            splitwiseManager.addExpense(expense2);
            splitwiseManager.addExpense(expense3);

            //Displaying balances
            Console.WriteLine("Balances:");
            splitwiseManager.showBalances();



        }
    }
}
