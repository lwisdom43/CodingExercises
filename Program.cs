using CodingExercise.CombinationSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 6, 7 };
            int target = 7;
            IList<IList<int>> results = Solution2.CombinationSum(arr, target);

            string displayResults = "";
            string displayArray = "";
            foreach (var r in results)
            {
                foreach (var i in r)
                {
                    displayArray += i.ToString() + ",";
                }

                displayResults += string.Format("[{0}],", displayArray.Remove(displayArray.Length - 1));
                displayArray = "";
            }

            Console.WriteLine(string.Format("[{0}]", displayResults.Remove(displayResults.Length - 1)));
            Console.ReadLine();
        }
    }
}
