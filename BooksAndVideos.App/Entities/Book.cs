using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAndVideos.App.Entities
{
    public class Book : Entity
    {
        public Book(string itemName)
        {
            ItemName = itemName;
        }

        public long Id { get; set; }
        public long CustomerId { get; set; }
        public string ItemName { get; set; }
        public int ProductType { get => (int)Product.Book; }
    }
}
