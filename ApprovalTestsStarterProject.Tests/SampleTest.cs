using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTestsStarterProject.Tests
{
    [TestClass]
    [UseReporter(typeof(VisualStudioReporter))]
    public class SampleTest
    {
        [TestMethod]
        public void TestStraightMsTest()
        {
            Assert.AreEqual(5, 5);
        }
        [TestMethod]
        public void TestWithApprovalTests()
        {
            Approvals.Verify(Code.SampleText());
        }
    }
}
