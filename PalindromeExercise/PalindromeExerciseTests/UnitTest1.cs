using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("mom", true)]
        [InlineData("Hello", false)]
        public void BoolPalindrome(string str1 , bool expected)
        {
            var TestCase = new WordSmith();
            bool PalindromeActual = TestCase.IsAPalindrome(str1);
            Assert.Equal(expected, PalindromeActual);
        }
    }
}
