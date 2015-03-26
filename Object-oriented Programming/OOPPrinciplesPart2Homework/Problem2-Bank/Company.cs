using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Bank
{
    public class Company : Customer
    {
        // constructors
        public Company(string companyName, int numOfAccounts)
            : base(companyName, numOfAccounts)
        {

        }
    }
}
