﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllAPI.Domain.Common;

namespace AllAPI.Domain.Entities
{
    public class Brand : EntityBase
    {
        public Brand()
        { 
        
        }
        public Brand(string name)
        {
            Name = name;
        }
        public  string Name { get; set; }
    }
}
