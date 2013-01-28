using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisi.MasterData.Contract;
using Pisi.MasterData.Models;

namespace Pisi.MasterData
{
    public class PeriodRepository
    {
        public IList<PayrollPeriod> LoadAllPeriod()
        {
            using (var db = new pisidataContext())
            {
                var query = from p in db.tblMonths
                            where p.monClose.Equals(true)
                            select new PayrollPeriod() { Code = p.MonthID, Name = p.monName };
                
                return query.ToList();
            }
        }
    }
}
