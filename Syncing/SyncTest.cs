using System.Collections.Generic;
using Xunit;

namespace DeveloperSample.Syncing
{
    public class SyncTest
    {
        [Fact]
        public void CanInitializeCollection()
        {
            var debug = new SyncDebug();
            var items = new List<string> { "one", "two" };
            var result = debug.InitializeList(items);
            Assert.Equal(items.Count, result.Count);
        }

        [Fact]
        public void ItemsOnlyInitializeOnce()
        {
            var debug = new SyncDebug();
            var items = new List<string> { "one", "two", "two" };
            var result = debug.InitializeListWithLock(items);
            Assert.Equal(items.Count, result.Count);
        }
    }
}
