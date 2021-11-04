using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface.ShapeAbstraction
{
    public abstract class Shape
    {
        public abstract decimal Area();
        public abstract decimal Length();
        public abstract decimal GetDioganal();

        public virtual void ShowName()
        {
            Console.WriteLine("Shape!");
        }

    }
}
