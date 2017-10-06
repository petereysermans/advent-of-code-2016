using System.Runtime.InteropServices;
using AdventOfCode2016.Day8.Classes;
using NUnit.Framework;

namespace AdventOfCode2016.Day8.TestFixtures
{
    [TestFixture]
    public class When_solving_part_1
    {
        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new Display();
        }

        [Test]
        public void Then_test_case_1_should_return_the_correct_output()
        {
            _classUnderTest.Instruct("rect 3x2");
            _classUnderTest.Print();

             /*
             ###...............................................
             ###...............................................
             ..................................................
             ..................................................
             ..................................................
             ..................................................
             */
        }

        [Test]
        public void Then_test_case_2_should_return_the_correct_output()
        {
            _classUnderTest.Instruct("rect 3x2");
            _classUnderTest.Instruct("rotate column x=1 by 1");
            _classUnderTest.Print();

             /*
             #.#...............................................
             ###...............................................
             .#................................................
             ..................................................
             ..................................................
             ..................................................
             */
        }

        private Display _classUnderTest;
    }
}
