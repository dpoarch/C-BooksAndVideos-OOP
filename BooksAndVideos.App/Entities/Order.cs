using BooksAndVideos.App.Services;
using BooksAndVideos.App.Rule;

namespace BooksAndVideos.App.Entities
{
    public class Order
    {
        private readonly IOrderService _processor;

        public Order(IOrderService processor)
        {
            _processor = processor;
        }

        public void CompletePurchase(PurchaseOrder model)
        {
            _processor.ProcessOrder(model.Items);
        }
    }
}
