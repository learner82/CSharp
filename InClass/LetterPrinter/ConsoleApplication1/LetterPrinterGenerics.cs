using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LetterPrinterGenerics<T>
    {
        public T Id { get; set; }
        public string Letter { get; private set; }

        private static Random r;
        public LetterPrinterGenerics(T Id,string Letter)
        {
            if (Letter.Length > 1)
                throw new ArgumentException("The Letter parameter should be of length 1");
            this.Letter = Letter;
            if (r==null)
                r = new Random();
        }

        public string GenerateRandomLengthSequence()
        {
            int times = r.Next(1, 10);
            string result = "";
            for (int i = 0; i < times; i++)
                result = result + Letter;

            return result;
        }
    }
}
