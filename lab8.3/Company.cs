using System;
using System.Collections.Generic;
using System.Text;

namespace lab8._3
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
