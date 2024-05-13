using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstApplication
    {
        [TestMethod]
        public void instanceConstructorOk()
        {
            clsApplication jobApplication = new clsApplication();
            Assert.IsNotNull(jobApplication);
        }
    }
}
