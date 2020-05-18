using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class DataEngine
    {
        public IList<DeviceItem> GenerateDeviceItem()
        {
            var ran = new Random();
            return new[] {
                new DeviceItem() { DeviceId = "1", TimeStamp = DateTime.Now, Occupied = ran.Next(0, 1) },
                new DeviceItem() { DeviceId = "2", TimeStamp = DateTime.Now, Occupied = ran.Next(0, 1) },
                new DeviceItem() { DeviceId = "3", TimeStamp = DateTime.Now, Occupied = ran.Next(0, 1) }
                };
        }
    }
}
