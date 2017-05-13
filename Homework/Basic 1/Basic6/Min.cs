using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic6
{
    public class Min
    {
        private List<double> _numbers;
        private List<float> _numbersfloat;

        public Min()
        {
            _numbers = new List<double>();
            _numbersfloat = new List<float>();

        }

        public void AddNumber(double x)
        {
            _numbers.Add(x);
        }


        public void AddNumber(float x)
        {
            _numbers.Add(x);
        }

        public double GetMin()
        {
            double smaller = double.MaxValue;
            foreach (double s in _numbers)
                if (s < smaller) smaller = s;

            return smaller;
        }


        public float GetMinFloat()
        {
            float smaller = float.MaxValue;
            foreach (float s in _numbers)
                if (s < smaller) smaller = s;

            return smaller;
        }
    }
}
