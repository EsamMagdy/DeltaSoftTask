﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Data
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreationTime = DateTime.Now;
        }
        public int Id { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime CreationTime { get; set; }
        public DateTime ModificationTime { get; set; }
    }
}
