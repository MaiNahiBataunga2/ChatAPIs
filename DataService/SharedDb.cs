using ChatAPIs.Models;
using System.Collections.Concurrent;

namespace ChatAPIs.DataService
{
    public class SharedDb
    {
        private readonly ConcurrentDictionary<string, UserConnections> _connections = new ConcurrentDictionary<string, UserConnections>();

        public ConcurrentDictionary<string, UserConnections> Connections => _connections;
    }
}
