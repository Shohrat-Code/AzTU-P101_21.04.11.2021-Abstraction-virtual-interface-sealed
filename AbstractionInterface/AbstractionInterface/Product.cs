using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    class Product :AbsProduct, IProduct, IProduct2
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public override bool Create()
        //{
        //    throw new NotImplementedException();
        //}

        //public override bool Delete()
        //{
        //    throw new NotImplementedException();
        //}

        //public override bool Get()
        //{
        //    throw new NotImplementedException();
        //}

        //public override bool Update()
        //{
        //    throw new NotImplementedException();
        //}
        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public override string Info()
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public bool Test()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
