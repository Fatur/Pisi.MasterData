using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pisi.MasterData.Contract;

namespace Pisi.MasterData.UnitTest
{
    /// <summary>
    /// Summary description for VerificationTest
    /// </summary>
    [TestClass]
    public class VerificationTest
    {
        [TestMethod]
        public void LoadEmployeeByVerificationKey()
        {
            VerificationRepository repo = new VerificationRepository();
            VerificationEmployee employee = repo.LoadByKey("0007VT1");
            Assert.AreEqual("0007", employee.EmployeeId);
            Assert.AreEqual("Muhammad Nur Ali Aris", employee.Name);
            Assert.AreEqual("Jl. Sedanau No. 08 RT01 RW10, Bengkong Kartini, Batam", employee.Address);
            Assert.AreEqual("Meral Karimun", employee.BirthPlace);
            Assert.AreEqual(new DateTime(1958,3,1), employee.BirthDate);

        }
    }
}
