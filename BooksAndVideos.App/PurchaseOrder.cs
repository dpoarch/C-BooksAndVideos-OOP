using System;
using System.Collections.Generic;
using System.Text;
using BooksAndVideos.App.Entities;

namespace BooksAndVideos.App
{
    public class PurchaseOrder
    {
        public long PurchaseOrderId { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<Entity> Items { get; set; }
        public long CustomerId { get; set; }
    }
}
