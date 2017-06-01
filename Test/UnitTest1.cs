using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdamOneilSoftware;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ViewContainingFolder()
        {
            Shell.ViewFileLocation(@"C:\Users\Adam\Dropbox\Visual Studio 2017\Projects\PwdKeeper\PwdKeeper.sln");
        }

        [TestMethod]
        public void ViewFolder()
        {
            Shell.ViewFolder(@"C:\Users\Adam\Dropbox\Visual Studio 2017\Projects");
        }

        [TestMethod]
        public void ViewDocument()
        {
            Shell.ViewDocument(@"C:\Users\Adam\Dropbox\Visual Studio 2017\Projects\Postulate.Sql\Postulate.Sql.sln");
        }
    }
}
