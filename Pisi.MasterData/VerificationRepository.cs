using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pisi.MasterData.Contract;
using Pisi.MasterData.Models;

namespace Pisi.MasterData
{
    public class VerificationRepository
    {
        public VerificationEmployee LoadByKey(string key)
        {
            using (var db = new pisidataContext())
            {
                var query = from p in db.tblEmployees
                            join v in db.tblUserVerifications on p.EmployeeID equals v.EmployeeId 
                            where v.VeryficationKey.Equals(key)
                            select new VerificationEmployee() { 
                                 EmployeeId =p.EmployeeID,
                                  Name =p.empName,
                                   Address =p.empAddress,
                                    BirthPlace =p.empBirthPlace,
                                      BirthDate =p.empBirthDate 
                            };

                return query.FirstOrDefault();
            }
        }
    }
}
