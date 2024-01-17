using SplitwiseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseApplication.Interface
{
    internal interface ISettlement
    {
        User getDebtor();
        User getCreditor();
        double getAmount();

    }
}
