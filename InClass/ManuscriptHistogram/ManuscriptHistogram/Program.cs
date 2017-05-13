using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptHistogram
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int,int> f=(x=> { return x + 1; });

            //TODO: Διάβασε το αρχείο και πάρε τα περιεχόμενά του
            StreamReader Reader = new StreamReader(@"C:\Users\ipplos\Desktop\ManuscriptHistogram\ManuscriptHistogram\bin\Debug\"+args[0]);
            string FileContents =Reader.ReadToEnd();
            Reader.Close();
            //Console.WriteLine(FileContents);

            //TODO: Δες στην FileContents πόσες φορές εμφανίζεται ο κάθε χαρακτήρας
            List<SingleCharCount> CharCount = new List<SingleCharCount>();
            for (int i = 0; i < FileContents.Length; i++)
            {
                string CurrentChar = FileContents[i].ToString();
                if (CurrentChar == " " || CurrentChar == "\r" || CurrentChar == "\n")
                    continue;

                SingleCharCount Item = SingleCharCount.GetItemFromList(CharCount, CurrentChar);
                if (Item == null)
                {
                    SingleCharCount NewCharCount=new SingleCharCount(CurrentChar);
                    CharCount.Add(NewCharCount);
                }
                else
                {
                    Item.Times++;
                }
            }

            CharCount = (from p in CharCount orderby p.Char select p).ToList();

            //TODO: Τύπωσε τα αποτελέσματα
            for (int i = 0; i < CharCount.Count; i++)
            {
                SingleCharCount Current = CharCount[i];
                Console.WriteLine($"Char: {Current.Char} \t\t Times: {Current.Times}");
            }

            //foreach (SingleCharCount Current in CharCount)
            //    Console.WriteLine($"Char: {Current.Char} \t\t Times: {Current.Times}");

            Console.ReadKey();

        }

        
    }
}
