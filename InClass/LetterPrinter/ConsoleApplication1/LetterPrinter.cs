using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LetterPrinter
    {
        public int Id { get; set; }
        public string Letter { get; private set; }

        private static Random r;
        public LetterPrinter(int Id,string Letter)
        {
            _init(Id, Letter);
            //if (Letter.Length > 1)
            //    throw new ArgumentException("The Letter parameter should be of length 1");
            //this.Letter = Letter;
            //if (r==null)
            //    r = new Random();
        }

        public LetterPrinter()
        {
            //Id = -1;
            //Letter = "-";
            //if (r == null)
            //    r = new Random();

            _init(-1, "-");
        }

        private void _init(int Id,string Letter)
        {
            if (Letter.Length > 1)
                throw new ArgumentException("The Letter parameter should be of length 1");
            this.Letter = Letter;
            if (r == null)
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
