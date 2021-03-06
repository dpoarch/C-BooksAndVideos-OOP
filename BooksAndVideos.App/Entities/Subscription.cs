﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAndVideos.App.Entities
{
    public class Subscription: Entity
    {
        public Subscription(string itemName)
        {
            ItemName = itemName;
        }

        public long Id { get; set; }
        public long CustomerId { get; set; }
        public string ItemName { get; set; }
        public int ProductType { get => (int)Product.Subscription; }
    }
}

