using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic4
{
    public class Basic4
    {
        private double _x1;
        private double _x2;
        private double _x3;

        public double Result { get; private set; }

        public Basic4 (double X, double y, double z)
        {
            _x1 = X;
            _x2 = y;
            _x3 = z;

        }

        public double Add()
        {
            Result = _x1 + _x2 + _x3;
            return Result;
        }
        public double Subtrack()
        {
            Result = _x1 - _x2 - _x3;
            return Result;
        }
        public double Multiply()
        {
            Result = _x1 * _x2 * _x3;
            return Result;
        }
        public double Divide()
        {
            Result = _x1 / _x2 / _x3;
            return Result;
        }

    }
}
