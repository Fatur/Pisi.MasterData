using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pisi.MasterData.Contract
{
    public class VerificationEmployee
    {
        public string EmployeeId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string BirthPlace { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
