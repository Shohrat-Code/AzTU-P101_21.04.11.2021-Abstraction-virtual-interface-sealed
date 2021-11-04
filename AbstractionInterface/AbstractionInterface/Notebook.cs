using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    class Notebook : AbsProduct
    {
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public byte RAM { get; set; }
        public string HDD { get; set; }
        public override string Info()
        {
            return $"Name: {this.Name}, Price: {this.Price}, RAM: {this.RAM}, HDD: {this.HDD}";
        }
    }
}
