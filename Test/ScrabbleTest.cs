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
        public void CountRepeats_SearchSentenceForWord_HelloInHelloWorldis1()
        {
            //Arrange
            RepeatCounter testCounter = new RepeatCounter("hello world","hello");

            //Act
            int testResult = testCounter.CountRepeats();

            //Accept
            Assert.Equal(1, testResult);
        }
        [Fact]
        public void CountRepeats_SearchSentenceForMultipleWordMatch_HelloInHelloHelloWorld2()
        {
            //Arrange
            RepeatCounter testCounter = new RepeatCounter("hello hello world","hello");

            //Act
            int testResult = testCounter.CountRepeats();

            //Accept
            Assert.Equal(2, testResult);
        }
        [Fact]
        public void CountRepeats_SearchSentenceForCaseSensitiveWordMatch_HELLOInHelloWorld()
        {
            //Arrange
            RepeatCounter testCounter = new RepeatCounter("hello world","HELLO");

            //Act
            int testResult = testCounter.CountRepeats();

            //Accept
            Assert.Equal(1, testResult);
        }

    }
}
