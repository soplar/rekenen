using Microsoft.VisualStudio.TestTools.UnitTesting;
using rekenen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekenen.Tests
{
    [TestClass()]
    public class classRekenenTests
    {
        [TestMethod()]
        public void OptellenTest()
        {
            // arrange  
            int testGetal1 = 4;
            int testGetal2 = 9;
            int verwachteUitkomst = 13;
            int werkelijkeUitkomst;
            
            // act
            classRekenen myFunctie = new classRekenen();
            werkelijkeUitkomst = myFunctie.Optellen(testGetal1,testGetal2);

            // assert  
            Assert.AreEqual(verwachteUitkomst, werkelijkeUitkomst);
        }

        [TestMethod()]
        public void DelenTest()
        {
            Assert.Fail();
        }
    }
}