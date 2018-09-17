using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Linq;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var addresses = new ConcurrentBag<String>();
            var sites = new string[] { "www.google.com", "www.amazon.com", "www.apple.com",
                "www.microsoft.com", "www.facebook.com" };
            Parallel.ForEach(sites, x =>
            {
                addresses.Add(System.Net.Dns.GetHostEntry(x).AddressList.First().ToString());
            });
            foreach (var address in addresses)
            {
                Console.WriteLine(address);
            }
        }
    }
}
