using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment2
{
    public class StarWarsClass
    {
        public static int AddStarWarsCharacters(string[] starWarsCharactersArray)
        {
            if (starWarsCharactersArray.Contains("Yoda"))
            {
                return Array.IndexOf(starWarsCharactersArray, "Yoda");
            }
            return -1;
        }

        public static string DeathStarCombat(Dictionary<string, int> characterAttacksDictionary)
        {
            var maxValueKey = characterAttacksDictionary.OrderByDescending(x => x.Value).First().Key;
            return maxValueKey;
        }

        public static string TryToCatchDarthVader(string userInput)
        {
            try
            {
                Int32.Parse(userInput);
                return "Vader Was Captured!";
            }
            catch (FormatException)
            {
                return "Vader Got Away!";
            }
        }

    }
}
