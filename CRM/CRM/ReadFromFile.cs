using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRM
{
    class ReadFromFile
    {


        public DataTable ReadTxtToDataTable(string path, int numberOfColumns)
        {
            Customer cus = new Customer();
            //private void loadDatasetToData(DataSet ds)
            //{
            //    
            //    foreach (DataTable dt in ds.Tables)
            //    {
            //        foreach (DataRow dr in dt.Rows)
            //        {

            //        }
            //    }


            //}
            File.WriteAllLines(path, File.ReadAllLines(path).Where(l => !string.IsNullOrWhiteSpace(l)));
            DataTable dt = new DataTable();
            
                for (int col = 0; col < numberOfColumns; col++)
                    dt.Columns.Add(new DataColumn("Column" + (col + 1).ToString()));

            string[] lines = System.IO.File.ReadAllLines(path);
            
            foreach (string line in lines)
                {
                    var rows = line.Split('\n');
                    foreach (string s in rows)
                    {
                        var cols = s.Split(';');
                        DataRow dr = dt.NewRow();
                        for (int index = 0; index < numberOfColumns; index++)
                        {
                            dr[index] = cols[index];
                        }

                        dt.Rows.Add(dr);
                    }
                     

                }

            
            return dt;
        }

        public DataTable ConvertDataSet (DataTable dt)
        {
            
            Utils ut = new Utils();

            int rows = dt.Rows.Count;

            dt.Columns["Column1"].ColumnName = "Name";
            dt.Columns["Column2"].ColumnName = "LastName";
            dt.Columns["Column3"].ColumnName = "MobilePhone";
            dt.Columns["Column4"].ColumnName = "HomePhone";
            dt.Columns["Column5"].ColumnName = "SpouseName";
            dt.Columns["Column6"].ColumnName = "KidsName";
            dt.Columns["Column7"].ColumnName = "LocationEvent";
            dt.Columns["Column8"].ColumnName = "LocationDate";
            dt.Columns["Column9"].ColumnName = "EventsTotalCost";
            dt.Columns["Column10"].ColumnName = "EventPaid";
            dt.Columns["Column11"].ColumnName = "Comments";
            dt.Columns["Column12"].ColumnName = "EventType";
            dt.Columns["Column13"].ColumnName = "Email";

            return dt;
        }
    }
}
