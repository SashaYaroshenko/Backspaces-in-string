namespace Solution
{
    using NUnit.Framework;
    using System;
    using ConsoleApp1;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("ac", Kata.CleanString("abc#d##c"));
            Assert.AreEqual("", Kata.CleanString("abc####d##c#"));
        }
    }
}