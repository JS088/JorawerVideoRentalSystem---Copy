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
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            try {
                //this code is used check and test empty method of the class
                Form1 instance=new Form1();
                instance.empty();
            }
            catch (Exception e) {
                Assert.Fail();
            }

        }
    }
}