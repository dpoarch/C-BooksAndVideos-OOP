using System;
using System.Collections.Generic;
using System.Text;
using BooksAndVideos.App.Entities;
using BooksAndVideos.App.Services;

namespace BooksAndVideos.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Order basket = new Order(new OrderService());

            IEnumerable<Entity> items = new Entity[] { new Book("Harry Potter and the Goblet of Fire"),
                                                     new Video("Transformers"),
                                                     new Subscription("Book Club Membership")
                                                    };

            basket.CompletePurchase(new PurchaseOrder()
            {
                PurchaseOrderId = 3344656,
                Total = 48.50m,
                Items = items,
                CustomerId = 4567890
            });
        }
    }
}
