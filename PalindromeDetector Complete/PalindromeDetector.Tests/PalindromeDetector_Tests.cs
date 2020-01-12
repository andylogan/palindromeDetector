using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeDetector.Tests
{
    [TestFixture]
    public class PalindromeDetector_Tests
    {
        [Test]
        public void Correctly_identifies_palindromes()
        {
            var subject = new PalindromeDetector();

            Assert.IsTrue(subject.IsPalindrome("noon"));
            Assert.IsTrue(subject.IsPalindrome("redivider"));
            Assert.IsTrue(subject.IsPalindrome("Apollo, PA"));
            Assert.IsTrue(subject.IsPalindrome("12345678987654321"));
            Assert.IsTrue(subject.IsPalindrome("Was it a car or a cat I saw?"));
            Assert.IsTrue(subject.IsPalindrome("Step on no pets."));
            Assert.IsTrue(subject.IsPalindrome("racecar"));
            Assert.IsTrue(subject.IsPalindrome("Hannah"));
            Assert.IsTrue(subject.IsPalindrome("deified"));
        }

        [Test]
        public void Correctly_identifies_non_palindromes()
        {
            var subject = new PalindromeDetector();

            Assert.IsFalse(subject.IsPalindrome("asdf"));
            Assert.IsFalse(subject.IsPalindrome("lorem ipsum"));
            Assert.IsFalse(subject.IsPalindrome("Service Management Group"));
        }
    }
}
