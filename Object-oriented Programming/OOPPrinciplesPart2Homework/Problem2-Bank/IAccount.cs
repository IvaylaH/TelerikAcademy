using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Bank
{
    interface IAccount
    {
        void DepositMoney(decimal depositedAmount);
        decimal CalculateInterest();
    }
}
