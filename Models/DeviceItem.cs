﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class DeviceItem
    {
        [Key]
        public string DeviceId { get; set; }

        public DateTime TimeStamp { get; set; }

        public int Occupied { get; set; }
    }
}
