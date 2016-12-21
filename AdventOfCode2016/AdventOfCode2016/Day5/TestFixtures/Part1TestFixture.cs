using AdventOfCode2016.Day5.Classes;
using NUnit.Framework;

namespace AdventOfCode2016.Day5.TestFixtures
{
    [TestFixture]
    public class When_searching_the_password_for_part_1
    {
        [Test]
        public void Then_the_correct_password_is_returned_when_the_door_id_is_abc()
        {
            var decryptor = new PasswordDecryptor();
            var result = decryptor.DecryptFor("abc");
            Assert.That(result, Is.EqualTo("18f47a30"));
        }

        [Test]
        public void Then_the_password_is_returned()
        {
            var decryptor = new PasswordDecryptor();
            var password = decryptor.DecryptFor("uqwqemis");
        }
    }
}
