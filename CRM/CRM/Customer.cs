using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }

        public string SpouseName { get; set; }
        public string KidsName { get; set; }
        public string LocationEvent { get; set; }
        public DateTime LocationDate { get; set; }
        public int EventsTotalCost { get; set; }
        public bool EventPaid { get; set; }
        public string Comments { get; set; }


        public enum EventType
        {
            Wedding = 0,
            Baftish = 1,
            Photoshoot = 2,

        }


    }
}
