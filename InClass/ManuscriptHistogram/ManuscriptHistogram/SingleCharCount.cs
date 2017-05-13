using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptHistogram
{
    public class SingleCharCount
    {
        public string Char { get; set; }
        public int Times { get; set; }

        public SingleCharCount(string Char)
        {
            this.Char = Char.ToUpper();
            Times = 1;
        }

        public static SingleCharCount GetItemFromList(List<SingleCharCount> list, string Char)
        {
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (Char.ToUpper() == list[i].Char) return list[i];
            //}

            //return null;

            List<SingleCharCount> ReturnList = (from p in list
                                                where p.Char == Char.ToUpper()
                                                select p).ToList();

            return ReturnList.FirstOrDefault();


        }
    }
}
