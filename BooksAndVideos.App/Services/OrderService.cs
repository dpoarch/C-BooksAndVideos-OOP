using BooksAndVideos.App.Entities;
using System;
using System.Collections.Generic;
using BooksAndVideos.App.Rule;

namespace BooksAndVideos.App.Services
{
    public class OrderService : IOrderService
    {
        public void ProcessOrder(IEnumerable<Entity> items)
        {
            foreach (Entity item in items)
            {
                IRule rule;
                switch (item.ProductType)
                {
                    case (int)Product.Book:
                        rule = new ProductRule(item);
                        break;
                    case (int)Product.Video:
                        rule = new ProductRule(item);
                        break;
                    case (int)Product.Subscription:
                        rule = new MembershipRule(item);
                        break;
                    default:
                        rule = null;
                        break;
                }

                if (rule != null)
                {
                    rule.CompleteRule();
                }
            }
        }
    }
}
