using SplitwiseApplication.Expense;
using SplitwiseApplication.Interface;
using SplitwiseApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication
{
    internal class SplitwiseManager
    {
        private static SplitwiseManager instance;
        private Dictionary<User, double> balances;
        private  SplitwiseManager()
        {
            balances = new Dictionary<User, double>();
        } 
        public static SplitwiseManager getInstance() // TODO - check synchronization
        {
            
                if (instance == null)
                {
                    instance = new SplitwiseManager();
                }
                return instance;
                      
        }

        public void addExpense(IExpense expense)
        {
            balances.Add(expense.getPayer(), balances.GetValueOrDefault(expense.getPayer(), defaultValue: 0.0) + expense.getAmount());
            if(expense.getType() == ExpenseType.GROUP)
            {
                GroupExpense groupExpense = (GroupExpense)expense;
                double perPersonShare = expense.getAmount()/groupExpense.getParticipants().Count();
                foreach (User participant in groupExpense.getParticipants()) { 
                    if(!participant.Equals(expense.getPayer()))
                    {
                        if (balances.ContainsKey(participant))
                        {
                            balances[participant] -= perPersonShare;
                        }
                    }
                }
            }

        }
        public void showBalances()
        {
            Console.WriteLine("Balances: ");
            foreach(KeyValuePair<User,double> entry in balances)
            {
                Console.WriteLine(entry.Key.getName() + ": " + entry.Value);
            }
        }
    }
}
