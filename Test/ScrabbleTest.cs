using Xunit;
using System;
using System.Collections.Generic;
using Counter.Objects;

namespace Counter
{
    public class RepeatCounterTest
    {
        [Fact]
        public void CountRepeats_SearchWordForWord_AinAis1()
        {
            //Arrange
            RepeatCounter testCounter = new RepeatCounter("a","a");

            //Act
            int testResult = testCounter.CountRepeats();

            //Accept
            Assert.Equal(1, testResult);
        }
        [Fact]
        public void CountRepeats_SearchSentenceForWord_AinAis1()
        {
            //Arrange
            RepeatCounter testCounter = new RepeatCounter("hello world","hello");

            //Act
            int testResult = testCounter.CountRepeats();

            //Accept
            Assert.Equal(1, testResult);
        }

    }
}
