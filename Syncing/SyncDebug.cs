using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperSample.Syncing
{
    public class SyncDebug
    {
        /// <summary>
        /// Initializes a collection using parallel processing.
        /// </summary>
        /// <param name="items">The items to initialize the collection with.</param>
        /// <returns>A list of initialized items.</returns>
        public List<string> InitializeList(IEnumerable<string> items)
        {
            var bag = new ConcurrentBag<string>();
            Parallel.ForEach(items, i =>
            {
                var r = i; // Avoid async/await in Parallel.ForEach as it is not thread-safe
                bag.Add(r);
            });
            return bag.ToList();
        }

        /// <summary>
        /// Initializes a collection with thread safety using locks.
        /// </summary>
        /// <param name="items">The items to initialize the collection with.</param>
        /// <returns>A list of initialized items.</returns>
        public List<string> InitializeListWithLock(IEnumerable<string> items)
        {
            var list = new List<string>();
            var locker = new object();
            Parallel.ForEach(items, i =>
            {
                lock (locker)
                {
                    list.Add(i);
                }
            });
            return list;
        }
    }
}
