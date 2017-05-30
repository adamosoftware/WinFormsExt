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
    }
}
