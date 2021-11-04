using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface.ShapeAbstraction
{
    public class Rectangle : Shape
    {
        private decimal _length;
        private decimal _width;

        public Rectangle(decimal length, decimal width)
        {
            this._length = length;
            this._width = width;
        }
        public override decimal Area()
        {
            return this._width * this._length;
        }

        public override decimal GetDioganal()
        {
            return (decimal)Math.Sqrt((double)(this._length * this._length + this._width * this._width));
        }

        public override decimal Length()
        {
            return 2 * (this._length + this._width);
        }
    }
}
