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

        private string _input;
        private SupportsTlsSpecification _classUnderTest;
    }
}
