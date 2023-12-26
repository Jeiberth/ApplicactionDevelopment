using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCal.Models
{
    public class BankCharges
    {
        private double Balance;
        private int checks;



        public double MonthServFee(double Bal, int Ch)
        {
            Balance = Bal;
            checks = Ch;
            if (checks < 20)
            {
                if (Balance < 400)
                    return 10 + 15 + 0.10 * checks;
                else
                    return 10 + 0.10 * checks;
            }
            else if (checks < 40)
            {
                if (Balance < 400)
                    return 10 + 15 + 0.08 * checks;
                else
                    return 10 + 0.08 * checks;
            }
            else if (checks < 60)
            {
                if (Balance < 400)
                    return 10 + 15 + 0.06 * checks;
                else
                    return 10 + 0.06 * checks;
            }
            else
            {
                if (Balance < 400)
                    return 10 + 15 + 0.01 * checks;
                else
                    return 10 + 0.01 * checks;
            }
        }
            

    }
}
