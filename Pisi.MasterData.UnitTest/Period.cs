using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pisi.MasterData.Contract;

namespace Pisi.MasterData.UnitTest
{
    [TestClass]
    public class Period
    {
        [TestMethod]
        public void LoadAllClosedPeriod()
        {
            PeriodRepository repo = new PeriodRepository();
            IList<PayrollPeriod> list = repo.LoadAllPeriod();
            Assert.AreEqual(2, list.Count);
        }
    }
}
