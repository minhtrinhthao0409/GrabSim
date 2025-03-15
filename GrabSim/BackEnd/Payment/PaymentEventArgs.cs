using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Payment
{
    
    public class PaymentEventArgs : EventArgs
    {
        public bool Success { get; }
        public uint Amount { get; }
        public string Message { get; }
        public string PaymentMethod { get; }

        public PaymentEventArgs(bool success, uint amount, string message, string paymentMethod)
        {
            Success = success;
            Amount = amount;
            Message = message;
            PaymentMethod = paymentMethod;
        }
    }
    
}
