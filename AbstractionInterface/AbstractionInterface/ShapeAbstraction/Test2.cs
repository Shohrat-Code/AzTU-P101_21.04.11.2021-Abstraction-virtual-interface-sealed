using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface.ShapeAbstraction
{
    class Test2 : Test
    {
        public sealed override void ShowName()
        {
            //base.ShowName();
            Console.WriteLine("Test 2");
        }
    }
}
