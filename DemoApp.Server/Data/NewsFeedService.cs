using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Server.Data
{
    public class NewsFeedService
    {
        public NewsFeedService() { }

        public Task<FeedItem[]> GetNewsFeedAsync(int count)
        {
            return Task.FromResult(Enumerable.Range(1, count).Select(index => new FeedItem
            {
                Id = index,
                Title = $"Title {index}",
                Content = $"Content {index}"
            }).ToArray());
        }
    }
}
