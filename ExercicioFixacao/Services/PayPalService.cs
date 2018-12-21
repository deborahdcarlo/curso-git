using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao.Services
{
    public class PayPalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            return (0.01 * months)*amount;
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
