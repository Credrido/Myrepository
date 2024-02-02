using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public abstract class ArrayBase
    {

        public abstract void Createarray(bool randif);

        public ArrayBase(bool randif) { }

        public abstract void Getmiddle();

        public abstract void Print();

        protected abstract void Fillarray();

        protected abstract void Fillarrayrandomly();
    }
}
