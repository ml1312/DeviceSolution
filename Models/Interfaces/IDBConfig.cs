using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public interface IDBConfig
    {
        public string HostName { get; }

        public int PortNumber { get; }

        public string UserName { get; }

        public string Password { get; }
    }
}
