using SplitwiseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication.Interface
{
    internal interface IExpense
    {
        User getPayer();
        double getAmount();
        ExpenseType getType();
    }
}
