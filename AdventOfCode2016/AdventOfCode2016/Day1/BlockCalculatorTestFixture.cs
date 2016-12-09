using NUnit.Framework;

namespace AdventOfCode2016.Day1
{
    [TestFixture]
    // Following R2, L3 leaves you 2 blocks East and 3 blocks North, or 5 blocks away.
    public class When_the_moveset_is_r2_l3
    {
        [Test]
        public void Then_you_are_2_blocks_east()
        {
            var blockCalculator = new BlockCalculator();
            var result = blockCalculator.Calculate("R2, L3");

            Assert.That(result, Is.EqualTo(5));
        }
    }

    [TestFixture]
    // R2, R2, R2 leaves you 2 blocks due South of your starting position, which is 2 blocks away.
    public class When_the_moveset_is_r2_r2_r2
    {
        [Test]
        public void Then_you_are_2_blocks_south()
        {
            var blockCalculator = new BlockCalculator();
            var result = blockCalculator.Calculate("R2, R2, R2");
            Assert.That(result, Is.EqualTo(2));
        }
    }

    [TestFixture]
    // R5, L5, R5, R3 leaves you 12 blocks away
    public class When_the_moveset_is_r5_l5_r5_r3
    {
        [Test]
        public void Then_you_are_12_blocks_away()
        {
            var blockCalculator = new BlockCalculator();
            var result = blockCalculator.Calculate("R5, L5, R5, R3");
            Assert.That(result, Is.EqualTo(12));
        }
    }

    [TestFixture]
    public class Answer_the_question
    {
        [Test]
        public void Test()
        {
            var moveset =
                "R3, L5, R1, R2, L5, R2, R3, L2, L5, R5, L4, L3, R5, L1, R3, R4, R1, L3, R3, L2, L5, L2, R4, R5, R5, L4, L3, L3, R4, R4, R5, L5, L3, R2, R2, L3, L4, L5, R1, R3, L3, R2, L3, R5, L194, L2, L5, R2, R1, R1, L1, L5, L4, R4, R2, R2, L4, L1, R2, R53, R3, L5, R72, R2, L5, R3, L4, R187, L4, L5, L2, R1, R3, R5, L4, L4, R2, R5, L5, L4, L3, R5, L2, R1, R1, R4, L1, R2, L3, R5, L4, R2, L3, R1, L4, R4, L1, L2, R3, L1, L1, R4, R3, L4, R2, R5, L2, L3, L3, L1, R3, R5, R2, R3, R1, R2, L1, L4, L5, L2, R4, R5, L2, R4, R4, L3, R2, R1, L4, R3, L3, L4, L3, L1, R3, L2, R2, L4, L4, L5, R3, R5, R3, L2, R5, L2, L1, L5, L1, R2, R4, L5, R2, L4, L5, L4, L5, L2, L5, L4, R5, R3, R2, R2, L3, R3, L2, L5";

            var blockCalculator = new BlockCalculator();
            var result = blockCalculator.Calculate(moveset);

        }

    }


}
