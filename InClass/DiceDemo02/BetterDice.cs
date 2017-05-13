using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDemo02
{
    public class BetterDice
    {
        private static Random _r { get; set; } //Δεν  χρειάζεται το κάθε ζάρι να έχει άλλη γεννήτρια τυχαίων αριθμών
        public string Id { get; set; }
        public int Result { get; set; }
        public int Choice { get; private set; } // Το set είναι private γιατί δεν μπορεί να το ορίσει αυτό που θα χρησιμοποιήσει την κλάση απευθείας
        public bool Success { get; private set; } // Το set είναι private γιατί δεν μπορεί να το ορίσει αυτό που θα χρησιμοποιήσει την κλάση απευθείας
        public int WonTimes { get; private set; } // Το set είναι private γιατί δεν μπορεί να το ορίσει αυτό που θα χρησιμοποιήσει την κλάση απευθείας
        public int Times { get; private set; } // Το set είναι private γιατί δεν μπορεί να το ορίσει αυτό που θα χρησιμοποιήσει την κλάση απευθείας
        public int LostTimes
        {
            get
            {
                return Times - WonTimes;
            }
        }
        public decimal LostPerc
        {
            get
            {
                return LostTimes / Times;
            }
        }
        public BetterDice()
        {
            if (_r==null)
                _r = new Random();

            WonTimes = 0;
            Times = 0;
        }
        public void Throw(int Number)
        {
            Times++;
            Choice = Number;
            Result = _r.Next(1, 7);
            if (Number == Result)
            {
                Success = true;
                WonTimes++;
            }
            else
            {
                Success = false;
            }
        }
    }
}
