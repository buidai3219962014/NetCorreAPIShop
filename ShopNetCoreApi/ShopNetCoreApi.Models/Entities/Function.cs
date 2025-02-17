﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNetCoreApi.Models.Entities
{
    public class Function
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }
        public string Status { set; get; }
        public List<Permission> Permissions { get; set; }
    }
}
