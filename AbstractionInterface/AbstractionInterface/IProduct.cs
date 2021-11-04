using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    interface IProduct
    {
        bool Create();
        bool Update();
        bool Delete();
        bool Read();
    }
}
