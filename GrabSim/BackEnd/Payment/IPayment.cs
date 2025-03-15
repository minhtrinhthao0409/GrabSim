using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Payment
{
    public delegate void PaymentProcessedEventHandler(object sender, PaymentEventArgs e);
    public interface IPayment
    {
        bool Status { get; set; }
        bool ProcessPayment(uint amount);
        string GetPaymentMethod();
        event PaymentProcessedEventHandler PaymentProcessed;
    }
}
