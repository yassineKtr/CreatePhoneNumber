using Xunit;

namespace CreatePhoneNumber.Tests
{
    public class KataTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("(123) 456-7890", Kata.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
        }
    }
}

