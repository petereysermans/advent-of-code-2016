using AdventOfCode2016.Day5.Classes;
using NUnit.Framework;

namespace AdventOfCode2016.Day5.TestFixtures
{
    [TestFixture]
    public class When_searching_the_password_for_part_2
    {
        [Test]
        public void Then_the_correct_password_is_returned_for_abc()
        {
            var decryptor = new PasswordDecryptor();
            var result = decryptor.DecryptWithPositioningFor("abc");
            Assert.That(result, Is.EqualTo("05ace8e3"));
        }

        [Test]
        public void Then_the_password_is_returned_for_the_actual_door_id()
        {
            var decryptor = new PasswordDecryptor();
            var result = decryptor.DecryptWithPositioningFor("uqwqemis");
        }
    }
}
