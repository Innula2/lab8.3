﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab8._3
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
