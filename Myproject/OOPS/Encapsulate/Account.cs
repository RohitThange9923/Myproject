using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Encapsulate
{
    internal class Account
    {
        int accNo;
        string ahn;
        double ab;

        public int ACCNO
        {
            set { accNo = value; }
            get { return accNo; }

        }



        public string AHN
        {
            set { ahn = value; }
            get { return ahn; }

        }

        public double AB
        {
            set { ab = value; }
            get { return ab; }

        }
    }


        class Statement
        {
             static void Main(string[] args)
            {
                Account account = new Account();
                account.ACCNO = 100;
                account.AHN = "Raj";
                account.AB = 200000;
            }
        }
    }



