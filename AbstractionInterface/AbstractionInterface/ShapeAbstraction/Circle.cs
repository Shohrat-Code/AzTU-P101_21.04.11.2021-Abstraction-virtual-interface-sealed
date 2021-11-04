using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface.ShapeAbstraction
{
    public class Circle : Shape
    {
        private decimal _radius;

        public Circle(decimal radius)
        {
            this._radius = radius;
        }
        public override decimal Area()
        {
            return (decimal)Math.PI * this._radius * this._radius;
        }

        public override decimal GetDioganal()
        {
            return 2 * this._radius;
        }

        public override decimal Length()
        {
            return 2 * (decimal)Math.PI * this._radius;
        }

        public override void ShowName()
        {
            //base.ShowName();
            Console.WriteLine("Circle!");
        }
    }
}
