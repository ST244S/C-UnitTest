using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! 123";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Jenkins_HellowWorld´ú¸Õ¥Î.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
