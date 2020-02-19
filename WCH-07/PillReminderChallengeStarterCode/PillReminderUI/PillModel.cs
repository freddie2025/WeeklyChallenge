using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillReminderUI
{
    public class PillModel
    {
        public string PillName { get; set; }
        public DateTime TimeToTake { get; set; }
        public DateTime LastTaken { get; set; }

        public string PillInfo
        {
            get
            {
                return $"{ PillName } at { TimeToTake.ToString("h:mm tt") }";
            }
        }
    }
}
