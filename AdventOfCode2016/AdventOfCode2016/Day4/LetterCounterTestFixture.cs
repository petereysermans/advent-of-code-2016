using System.Linq;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace AdventOfCode2016.Day4
{
    [TestFixture]
    public class When_counting_the_letters
    {
        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new LetterCounter();
        }

        [Test]
        public void Then_the_letters_are_correctly_counted_if_there_are_2_room_parts_a_b()
        {
            _roomParts = "a-b";
            var result = _classUnderTest.Count(_roomParts).ToList();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Letter, Is.EqualTo("a"));
            Assert.That(result[0].Count, Is.EqualTo(1));

            Assert.That(result[1].Letter, Is.EqualTo("b"));
            Assert.That(result[1].Count, Is.EqualTo(1));
        }

        [Test]
        public void Then_the_letter_are_correctly_counted_and_sorted_if_the_room_parts_are_not_a_real_room()
        {
            _roomParts = "not-a-real-room";
            var result = _classUnderTest.Count(_roomParts).ToList();
            Assert.That(result.Count, Is.EqualTo(8));

            Assert.That(result[0].Letter, Is.EqualTo("o"));
            Assert.That(result[0].Count, Is.EqualTo(3));

            Assert.That(result[1].Letter, Is.EqualTo("a"));
            Assert.That(result[1].Count, Is.EqualTo(2));

            Assert.That(result[2].Letter, Is.EqualTo("r"));
            Assert.That(result[2].Count, Is.EqualTo(2));
        }

        private string _roomParts;
        private LetterCounter _classUnderTest;
    }
}
