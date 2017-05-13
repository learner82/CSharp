using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NoLetterFoundChar = "-";
            List<string> WordToFind = new List<string>();
            List<string> LettersTried = new List<string>();
            string CurrentLetter = "";
            int PlayerLives = 5;
            List<string> CurrentWordFound = new List<string>();

            IUserReader UserReader = new ConsoleUserReader();
            IUserInformer UserInformer = new ConsoleUserInformer();

            // Διάβασε τη λέξη
            string Word = UserReader.GetStringFromUser("Give me the word: ");

            // Μετέτρεψέ την σε λίστα
            for (int i = 0; i < Word.Length; i++)
            {
                WordToFind.Add(Word[i].ToString().ToUpper());
                if ((i == 0) || (i == Word.Length - 1))
                    CurrentWordFound.Add(Word[i].ToString().ToUpper());
                else
                    CurrentWordFound.Add(NoLetterFoundChar);

                //CurrentWordFound.Add(((i == 0) || (i == Word.Length - 1)) ? Word[i].ToString().ToUpper() : "-");

            }

            Console.Clear();
            bool PlayerWon = false;
            while (PlayerLives>=0 && !PlayerWon)
            {
                //Παρε απο τον χρηστη ενα γραμμα
                CurrentLetter = UserReader.GetInstantLetterInput("Give me the letter: ");

                //αποθηκευσε το στα given letters
                
                if (!LettersTried.Contains(CurrentLetter))
                {
                    if (WordToFind.Contains(CurrentLetter))
                    {
                        for (int i = 1; i < WordToFind.Count-1; i++)
                        {
                            if (WordToFind[i] == CurrentLetter)
                                CurrentWordFound[i] = CurrentLetter;
                        }
                    }
                    else
                    {
                        PlayerLives--;
                    }
                    LettersTried.Add(CurrentLetter);
                }

                UserInformer.ShowState(CurrentWordFound, LettersTried,PlayerLives);
                
                PlayerWon = CheckWinState(CurrentWordFound, NoLetterFoundChar);
            }

            if (PlayerWon)
                UserInformer.ShowMessage("You won");
            else
                UserInformer.ShowMessage("You lost");

            UserReader.GetInstantLetterInput("Press any key to end");
        }
        public static bool CheckWinState(List<string> CurrentWordFound,string Letter)
        {
            //if (CurrentWordFound.IndexOf(Letter) == -1)
            //    return  true;
            //return false;

            return !CurrentWordFound.Contains(Letter);
        }
    }
}
