using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    class WashMashine : AbsProduct
    {
        public override string Name { get ; set ; }
        public override decimal Price { get ; set ; }
        public string DoorShape { get; set; }
        public byte Capacity { get; set; }

        public override string Info()
        {
            return $"Name: {this.Name}, Price: {this.Price}, Door shape: {this.DoorShape}, Capacity: {this.Capacity}";
        }
    }
}
