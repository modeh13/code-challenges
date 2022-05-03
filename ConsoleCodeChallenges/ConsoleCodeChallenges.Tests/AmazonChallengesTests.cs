using ConsoleCodeChallenges.Interfaces;
using Xunit;

namespace ConsoleCodeChallenges.Tests
{
    public class AmazonChallengesTests
    {
        private readonly IAmazonChallenges _amazonChallenges;

        public AmazonChallengesTests()
        {
            _amazonChallenges = new AmazonChallenges();
        }
        
        #region Decreasing Ratings
        [Fact]
        public void CalculateNumberOfDecreasingRatings_Returns_Seven()
        {
            // Arrange
            var ratings = new[] { 4, 2, 1, 3, 1, 2 };
            
            // Act
            var decreasingRatings = _amazonChallenges.CalculateNumberOfDecreasingRatings(ratings);

            // Assert
            Assert.Equal(7, decreasingRatings);
        }

        [Fact]
        public void CalculateNumberOfDecreasingRatings_Returns_Eight()
        {
            // Arrange
            var ratings = new[] { 4, 3, 2, 4, 1 };
            
            // Act
            var decreasingRatings = _amazonChallenges.CalculateNumberOfDecreasingRatings(ratings);

            // Assert
            Assert.Equal(8, decreasingRatings);
        }
        
        [Fact]
        public void CalculateNumberOfDecreasingRatings_Returns_Fifteen()
        {
            // Arrange
            var ratings = new[] { 6, 5, 4, 3, 4, 3, 1, 2, 1, 8, 7, 6, 5, 4, 3, 2, 1, 4 };
            
            // Act
            var decreasingRatings = _amazonChallenges.CalculateNumberOfDecreasingRatings(ratings);

            // Assert
            Assert.Equal(54, decreasingRatings);
        }
        #endregion

        #region Maximum Word Deviation

        [Fact]
        public void GetMaximumWordDeviation_Returns_Zero()
        {
            // Arrange
            const string word = "aabbcccd"; // bccc or cccd => c: 3, d: 1 -> 3-1: 2
            
            // Act
            var maximumDeviation = _amazonChallenges.GetMaximumWordDeviation(word);

            // Assert
            Assert.Equal(2, maximumDeviation);
        }
        #endregion
    }
}
