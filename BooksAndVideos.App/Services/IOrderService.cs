using System;
using System.Collections.Generic;
using BooksAndVideos.App.Entities;

namespace BooksAndVideos.App.Services
{
    public interface IOrderService
    {
        void ProcessOrder(IEnumerable<Entity> items);
    }
}
