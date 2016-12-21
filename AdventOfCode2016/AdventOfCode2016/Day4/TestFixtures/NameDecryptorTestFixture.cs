using NUnit.Framework;

namespace AdventOfCode2016.Day4
{
    [TestFixture]
    public class When_decrypting_a_name
    {
        [SetUp]
        public void SetUp()
        {
            _nameDecryptor = new NameDecryptor();
        }

        [Test]
        public void Then_the_decrypted_name_is_returned()
        {
            _name = "qzmt-zixmtkozy-ivhz-343[unused]";
            var result = _nameDecryptor.Decrypt(_name);
            Assert.That(result, Is.EqualTo("very encrypted name"));
        }

        private NameDecryptor _nameDecryptor;
        private string _name;
    }
}
