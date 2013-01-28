using System;
using System.Collections.Generic;

namespace Pisi.MasterData.Models
{
    public class tblUserVerification
    {
        public string EmployeeId { get; set; }
        public string VeryficationKey { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
    }
}
