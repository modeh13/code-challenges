using System.Threading.Tasks;

namespace ConsoleCodeChallenges.Interfaces
{
    public interface IAmazonChallenges
    {
        int CalculateNumberOfDecreasingRatings(int[] ratings);

        int GetMaximumWordDeviation(string word);
    }
}
