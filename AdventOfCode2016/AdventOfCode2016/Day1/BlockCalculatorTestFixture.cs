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
            var result = blockCalculator.Calculate();
        }
    }
}
