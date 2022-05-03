using System.Collections.Generic;
using ConsoleCodeChallenges.Interfaces;

namespace ConsoleCodeChallenges
{
    public class AmazonChallenges : IAmazonChallenges
    {
        #region Decreasing Ratings
        /// <summary>
        /// Determines the number of groups based on a array length.
        /// </summary>
        /// <param name="number">Integer which indicates the array length</param>
        /// <returns>Number of groups</returns>
        private static int GetNumberOfGroups(int number)
        {
            return (number * (number + 1)) / 2;
        }

        public int CalculateNumberOfDecreasingRatings(int[] ratings)
        {
            if (ratings == null || ratings.Length == 0) return 0;
            if (ratings.Length == 1) return ratings.Length;

            var decreasingRatings = 0;
            var index = 0;

            do
            {
                var maximumGroupSize = GetMaximumGroupSizeFromIndex(index, ratings);
                if (maximumGroupSize > 0)
                {
                    var numberOfGroups = GetNumberOfGroups(maximumGroupSize);

                    decreasingRatings += numberOfGroups;
                    index += maximumGroupSize;
                }
                else    
                    index++;
                

            } while (index < ratings.Length);
            
            return decreasingRatings;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">Initial index to start looking a group of ratings</param>
        /// <param name="ratings">A collection of <see cref="int"/> that represents the ratings</param>
        /// <returns>A size of group where ratings meet the decreasing criteria (r, r - 1, r - 2, ...)</returns>
        private static int GetMaximumGroupSizeFromIndex(int index, IReadOnlyList<int> ratings)
        {
            var groupSize = 0;
            var currentRating = ratings[index] + 1;
            
            for (var groupIndex = index; groupIndex < ratings.Count; groupIndex++)
            {
                if (currentRating == ratings[groupIndex] + 1)
                {
                    currentRating = ratings[groupIndex];
                    groupSize = groupIndex - index + 1;
                    continue;
                }

                break;
            }

            return groupSize;
        }
        #endregion
        
        #region MaximumWordDeviation
        public int GetMaximumWordDeviation(string word)
        {
            return 0;
        }
        #endregion
    }
}
