using System;
using System.Collections.Generic;

namespace Pisi.MasterData.Models
{
    public class tblMonth
    {
        public string MonthID { get; set; }
        public string MonSumID { get; set; }
        public string monName { get; set; }
        public Nullable<short> monDay { get; set; }
        public Nullable<short> monHoliday { get; set; }
        public string monMemo { get; set; }
        public bool monClose { get; set; }
        public Nullable<decimal> monQTY { get; set; }
        public bool monBonus { get; set; }
        public Nullable<bool> monExclude { get; set; }
        public string Computer { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
    }
}
