using AdventOfCode2016.Day7.Classes;
using NUnit.Framework;
using System.Linq;

namespace AdventOfCode2016.Day7.TestFixtures
{
    [TestFixture]
    public class When_solving_part_2 
    {
        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new SupportsSslSpecification();
        }

        [Test]
        public void Then_test_case_1_supports_ssl()
        {
            var result = _classUnderTest.IsSatisfied("aba[bab]xyz");
            Assert.That(result, Is.True);
        }

        [Test]
        public void Then_test_case_2_does_not_support_ssl()
        {
            var result = _classUnderTest.IsSatisfied("xyx[xyx]xyx");
            Assert.That(result, Is.False);
        }

        [Test]
        public void Then_test_case_3_supports_ssl()
        {
            var result = _classUnderTest.IsSatisfied("aaa[kek]eke");
            Assert.That(result, Is.True);

        }

        [Test]
        public void Then_test_case_4_supports_ssl()
        {
            var result = _classUnderTest.IsSatisfied("zazbz[bzb]cdb");
            Assert.That(result, Is.True);
        }
        
        [Test]
        public void Then_the_puzzle_can_be_solved()
        {
            var ipAddresses = Input.Text.Split('\n');
            var numberOfValidAddresses = 
                ipAddresses.Count(ip => _classUnderTest.IsSatisfied(ip));
        }

        private SupportsSslSpecification _classUnderTest;

    }
}
