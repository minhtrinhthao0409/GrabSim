using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabSim.BackEnd.Payment
{
    class CashPayment : IPayment
    {
        public bool Status { get; set; }
        public event PaymentProcessedEventHandler PaymentProcessed;

        public CashPayment(bool status)
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
            return "Tiền mặt";
        }

        protected virtual void OnPaymentProcessed(PaymentEventArgs e)
        {
            PaymentProcessed?.Invoke(this, e);
        }
    }
}
