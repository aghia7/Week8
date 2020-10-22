using System;
using System.Collections.Generic;
using System.Text;

namespace Week8Project.Core.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsBad { get; set; }
    }
}
