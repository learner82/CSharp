using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class WriteToFile
    {
        public DataSet ds = new DataSet();
        bool AllWentGood = false;
        public bool WriteToTxtFile(DataSet ds, string path)
        {
            
            Customer cus = new Customer();
            string fileName = "\\data.txt";
            StreamWriter sw = new StreamWriter(path + fileName, true);
            int i;
            sw.Write(Environment.NewLine);
            Utils ut = new Utils();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                object[] array = row.ItemArray;
                for (i = 0; i < array.Length - 1; i++)
                {
                    sw.Write(array[i].ToString() + ";");
                }
                sw.WriteLine(array[i].ToString() + '\n');
                AllWentGood = true;
            }
            sw.Flush();
            sw.Close();
            if (AllWentGood)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
