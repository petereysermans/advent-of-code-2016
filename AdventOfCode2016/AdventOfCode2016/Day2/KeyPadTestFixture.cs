using NUnit.Framework;

namespace AdventOfCode2016.Day2
{
    [TestFixture]
    public class When_the_code_is_ull
    {
        [Test]
        public void Then_the_current_button_is_1()
        {
            var keyPad = new KeyPad();
            var result = keyPad.Press("ULL");
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
