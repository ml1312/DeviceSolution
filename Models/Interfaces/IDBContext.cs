using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public interface IDBContext
    {
        public IDBConfig DBConfig { get; }

        public bool AddRecord(DeviceItem item);

        public DeviceItem GetRecord(string id);

        public bool ExistsDatabase(string dbName);

        public bool CreateDatabase(string dbName);
    }
}
