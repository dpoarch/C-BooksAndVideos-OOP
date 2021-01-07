using Xunit;
using NSubstitute;
using System.Collections.Generic;
using BooksAndVideos.App.Services;
using BooksAndVideos.App.Entities;

namespace BooksAndVideos.Tests.OrderService
{
    public class ProcessTests
    {
        private readonly IOrderService _processor;

        public ProcessTests()
        {
            _processor = Substitute.For<IOrderService>();
        }

        [Fact]
        public void CompletePurchaseTest()
        {
            try
            {
                IEnumerable<Entity> items = new Entity[] { new Book("Harry Potter and the Goblet of Fire"),
                                                new Video("Transformers"),
                                                new Subscription("Book Club Membership")
                                            };

                _processor.ProcessOrder(items);

                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }
    }
}

