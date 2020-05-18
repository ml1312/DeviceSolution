using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Models
{
    public class ElasticDBConfig : IDBConfig
    {
        private string _hostName;
        private int _port;

        public ElasticDBConfig(string hostName, int port)
        {
            _hostName = hostName;
            _port = port;
        }

        public string HostName {get { return _hostName; } }

        public int PortNumber => throw new NotImplementedException();

        public string UserName => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();
    }
}
