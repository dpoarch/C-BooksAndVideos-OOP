using System;
using System.Collections.Generic;
using System.Text;
using BooksAndVideos.App.Entities;

namespace BooksAndVideos.App.Rule
{
    public class ProductRule : IRule
    {
        private Entity _item;

        public ProductRule(Entity item)
        {
            _item = item;
        }

        public void CompleteRule()
        {
            GenerateShippingSlip();
        }

        private void GenerateShippingSlip()
        {
            // Generates a shipping slip
        }
    }
}
