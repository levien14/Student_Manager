﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Entities
{
    class AccessInfo
    {
        public string accessToken { get; set; }
        public string ownId { get; set; }
        public string cretedAt { get; set; }
        public string updatedAt { get; set; }
        public string expireAt { get; set; }

    }
}
