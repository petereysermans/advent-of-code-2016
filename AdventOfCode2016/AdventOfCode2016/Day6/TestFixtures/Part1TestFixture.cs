﻿using AdventOfCode2016.Day6.Classes;
using NUnit.Framework;
using Input = AdventOfCode2016.Day6.Classes.Input;

namespace AdventOfCode2016.Day6.TestFixtures
{
    [TestFixture]
    public class When_solving_part_1
    {
        [Test]
        public void Then_the_test_case_should_pass()
        {
            var decoder = new MessageDecoder();
            var result = decoder.DecodeUsingMostFrequentCharacters(Input.Test);
            Assert.That(result, Is.EqualTo("easter"));
        }

        [Test]
        public void Then_the_puzzle_can_be_solved()
        {
            var decoder = new MessageDecoder();
            var result = decoder.DecodeUsingMostFrequentCharacters(Input.Text);
        }
    }
}
