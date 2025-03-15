using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.Payment
{
    public class OnlinePayment : IPayment
    {
        public bool Status { get; set; }
        public event PaymentProcessedEventHandler PaymentProcessed;

        public OnlinePayment(bool status)
        {
            Status = status;
        }

        public bool ProcessPayment(uint amount)
        {
            bool result = Status;
            string message = result ? "Thanh toán thành công" : "Giao dịch thất bại! Xin vui lòng thử lại";
            OnPaymentProcessed(new PaymentEventArgs(result, amount, message, GetPaymentMethod()));
            return result;
        }

        public string GetPaymentMethod()
        {
            return "Thanh toán trực tuyến";
        }

        protected virtual void OnPaymentProcessed(PaymentEventArgs e)
        {
            PaymentProcessed?.Invoke(this, e);
        }
    }
}
