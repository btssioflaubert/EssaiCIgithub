using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEssaiCIGitHub
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a, b, c;
            a = 2; b = 3;
            c = EssaiCIGitHub.Program.somme(a, b);
            int result = 5;
            Assert.AreEqual(result, c, "les valeurs ne correspondent pas");
        }
    }
}
