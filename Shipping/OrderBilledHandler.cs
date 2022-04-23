using Billing.Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping
{
    public class OrderBilledHandler : IHandleMessages<OrderBilled>
    {
        static ILog log = LogManager.GetLogger<OrderBilledHandler>();

        public Task Handle(OrderBilled message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderBilled in Shipping, OrderId = {message.OrderId}, Shipping out product to buyer");

            return Task.CompletedTask;
        }
    }
}
