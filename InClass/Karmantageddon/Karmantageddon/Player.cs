using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmantageddon
{
    public class Player
    {
        private static Random _r;

        public string Name { get; set; }
        public int Karma { get; set; }

        private List<string> AllowedKeys;

        public bool Won
        {
            get
            {
                return Karma == 0;
            }
        }
        public Player(int Karma)
        {
            this.Karma = Karma;
            this.AllowedKeys = new List<string>();
            if (_r == null)
                _r = new Random();
        }

        public void AddKey(string k)
        {
            AllowedKeys.Add(k.ToUpper());
        }
        public string GetNextKey()
        {
            int idx = _r.Next(0, AllowedKeys.Count);
            return AllowedKeys[idx];
        }

        public bool MyKey(string k)
        {
            //for (int i = 0; i < AllowedKeys.Count; i++)
            //{
            //    string key = AllowedKeys[i];
            //    if (key == k) return true;
            //}

            foreach (string key in AllowedKeys)
                if (key == k.ToUpper()) return true;

            return false;
        }

        public void ActOnKey(string keyPressedStr)
        {
            if (MyKey(keyPressedStr))
                Karma = Karma - 1;
        }

        public override string ToString()
        {
            return $"{this.Name} : {this.Karma}";
        }
    }
}
