using SplitwiseApplication.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication
{
    internal class SettlementManager
    {
        private static SettlementManager instance;
        private List<ISettlement> settlements;
        private SettlementManager() { settlements= new List<ISettlement>(); }

        public static SettlementManager getInstance() {
           
                if (instance == null)
                {
                    instance = new SettlementManager();
                }
                return instance;
                      
        }
        public void addSettlement(ISettlement settlement)
        {
            settlements.Add(settlement);
        }
        public void showSettlements()
        {
            Console.WriteLine("Settlements:");
            foreach(ISettlement settlement in settlements)
            {
                Console.WriteLine(settlement.getDebtor().getName() +  " owes " + settlement.getCreditor().getName() + ": "+ settlement.getAmount());
            }
        }
    }
}
