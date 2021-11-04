using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    abstract class AbsProduct
    {
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
        public abstract string Info();
        //abstract public bool Get();
        //abstract public bool Create();
        //abstract public bool Update();
        //abstract public bool Delete();
    }
}
