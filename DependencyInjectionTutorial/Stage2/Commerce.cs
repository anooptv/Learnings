﻿using DependencyInjectionTutorial.Stage1;
namespace DependencyInjectionTutorial.Stage2
{
    public class Commerce
    {
        public Commerce(IBillingProcessor billingProcessor,ICustomerProcessor customerProcessor,INotifier notifier)
        {
            _BillingProcessor = billingProcessor;
            _CustomerProcessor = customerProcessor;
            _Notifier = notifier;
        }
        IBillingProcessor _BillingProcessor;
        ICustomerProcessor _CustomerProcessor;
        INotifier _Notifier;
        public void ProcessOrder(OrderInfo orderInfo)
        {
            _BillingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.CustomerEmail);
            _CustomerProcessor.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
            _Notifier.SendReceipt(orderInfo);
        }
    }
}
