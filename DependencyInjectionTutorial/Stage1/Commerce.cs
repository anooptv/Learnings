namespace DependencyInjectionTutorial.Stage1
{
    public class Commerce
    {
        public void ProcessOrder(OrderInfo orderInfo)
        {
            BillingProcessor billingProcessor = new BillingProcessor();
            CustomerProcessor customerProcessor = new CustomerProcessor();
            Notifier notifier = new Notifier();
            billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.CustomerEmail);
            customerProcessor.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
            notifier.SendReceipt(orderInfo);
        }
    }
}
