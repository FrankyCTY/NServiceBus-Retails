using NServiceBus;
using NServiceBus.Logging;
using Sales.Messages;

namespace Sales
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        static ILog log = LogManager.GetLogger<PlaceOrderHandler>();

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder in Sales, OrderId = {message.OrderId}");

            // Prepare event message
            var orderPlacedMessage = new OrderPlaced
            {
                OrderId = message.OrderId
            };

            // Publish event   
            return context.Publish(orderPlacedMessage);
        }
    }
}
