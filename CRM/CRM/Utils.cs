using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Utils
    {
        public DataTable CustomTable()
        {
            DataTable dt = new DataTable();
            DataColumn Name = new DataColumn("Name", typeof(string));
            DataColumn LastName = new DataColumn("LastName", typeof(string));
            DataColumn MobilePhone = new DataColumn("MobilePhone", typeof(string));
            DataColumn HomePhone = new DataColumn("HomePhone", typeof(string));
            DataColumn SpouseName = new DataColumn("SpouseName", typeof(string));
            DataColumn KidsName = new DataColumn("KidsName", typeof(string));
            DataColumn LocationEvent = new DataColumn("LocationEvent", typeof(string));
            DataColumn LocationDate = new DataColumn("LocationDate", typeof(DateTime));
            DataColumn EventsTotalCost = new DataColumn("EventsTotalCost", typeof(double));
            DataColumn EventPaid = new DataColumn("EventPaid", typeof(double));
            DataColumn Comments = new DataColumn("Comments", typeof(string));
            DataColumn EventType = new DataColumn("EventType", typeof(string));
            DataColumn Email = new DataColumn("Email", typeof(string));

            dt.Columns.Add(Name);
            dt.Columns.Add(LastName);
            dt.Columns.Add(MobilePhone);
            dt.Columns.Add(HomePhone);
            dt.Columns.Add(SpouseName);
            dt.Columns.Add(KidsName);
            dt.Columns.Add(LocationEvent);
            dt.Columns.Add(LocationDate);
            dt.Columns.Add(EventsTotalCost);
            dt.Columns.Add(EventPaid);
            dt.Columns.Add(Comments);
            dt.Columns.Add(EventType);
            dt.Columns.Add(Email);

            return dt;
        }
    }
}
