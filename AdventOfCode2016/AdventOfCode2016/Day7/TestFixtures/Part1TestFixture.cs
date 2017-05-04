using System.Linq;
using AdventOfCode2016.Day7.Classes;
using NUnit.Framework;

namespace AdventOfCode2016.Day7.TestFixtures
{
    [TestFixture]
    public class When_solving_part_1
    {
        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new SupportsTlsSpecification();
        }
        
        [Test]
        public void Then_test_case_1_supports_tls()
        {
            _input = "abba[mnop]qrst";
            var result = _classUnderTest.IsSatisfied(_input);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Then_test_case_2_does_not_support_tls()
        {
            _input = "abcd[bddb]xyyx";
            var result = _classUnderTest.IsSatisfied(_input);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Then_test_case_3_does_not_support_tls()
        {
            _input = "aaaa[qwer]tyui";
            var result = _classUnderTest.IsSatisfied(_input);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Then_test_case_4_supports_tls()
        {
            _input = "ioxxoj[asdfgh]zxcvbn";
            var result = _classUnderTest.IsSatisfied(_input);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Then_the_puzzle_can_be_solved()
        {
            var ipAddresses = Input.Text.Split('\n');
            var numberOfValidAddresses = ipAddresses.Count(ip => _classUnderTest.IsSatisfied(ip));
        }

        private string _input;
        private SupportsTlsSpecification _classUnderTest;
    }
}
