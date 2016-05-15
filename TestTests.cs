using NUnit.Framework;

namespace Test_Runner
{
    [TestFixture]
    public class TestTests
    {
        [Test]
        public void Passes()
        {
            
        }

        [Test]
        public void Fails()
        {
            Assert.Fail("This test fails.");
        }

        [Test]
        public void Ignore()
        {
            Assert.Ignore("This test is ignored.");
        }

        [Test]
        [Category("alpha")]
        public void CategoryAlphaOne()
        {   
        }

        [Test]
        [Category("alpha")]
        public void CategoryAlphaTwo()
        {
        }

        [Test]
        [Category("beta")]
        public void CategoryBetaOne()
        {
        }

        [Test]
        [Category("beta")]
        public void CategoryBetaTwo()
        {
        }
    }
}