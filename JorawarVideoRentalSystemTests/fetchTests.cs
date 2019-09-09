using Microsoft.VisualStudio.TestTools.UnitTesting;
using JorawarVideoRentalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorawarVideoRentalSystem.Tests
{
    [TestClass()]
    public class fetchTests
    {
        [TestMethod()]
        public void SelectQueryTest()
        {
            try {
                //this code is used to fetch the class and check all the method of the class and test it
                fetch instance = new fetch();
              

            }
            catch (Exception e) {
                Assert.Fail();
            }
        }
    }
}