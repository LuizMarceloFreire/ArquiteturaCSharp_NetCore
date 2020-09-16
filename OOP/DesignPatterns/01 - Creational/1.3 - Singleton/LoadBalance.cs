using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._3___Singleton
{
    internal sealed class LoadBalance
    {
        private static readonly LoadBalance Instance = new LoadBalance();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalance()
        {
            _servers = new List<Server>
            {
                new Server{ Id = Guid.NewGuid(), Name = "ServerI", IP = "120.14.220.18" },
                new Server{ Id = Guid.NewGuid(), Name = "ServerII", IP = "120.14.220.19" },
                new Server{ Id = Guid.NewGuid(), Name = "ServerIII", IP = "120.14.220.20" },
                new Server{ Id = Guid.NewGuid(), Name = "ServerIV", IP = "120.14.220.21" },
                new Server{ Id = Guid.NewGuid(), Name = "ServerV", IP = "120.14.220.22" },
            };
        }

        public static LoadBalance GetLoadBalance()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
