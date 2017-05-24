using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLibrary
{
    public class User
    {
        public static int _IDU = 0;
        public string UserNam { get; private set; }
        public int IDU { get; private set; }
        

        public User(string usernam)
        {
            this.UserNam = usernam;
            this.IDU = ++_IDU;

        }

        public override string ToString()
        {
            return $"{this.UserNam}";
        }
    }
}
