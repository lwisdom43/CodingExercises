using CodingExercise.CombinationSum;
using CodingExercises.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercises
{
    public class Program
    {
        /// <summary>
        /// Add enum following same format when a new coding exercise is added
        /// </summary>
        public enum CodingExerciseProject
        {
            ProjectsCombinationSum
        }

        public static void Main(string[] args)
        {
            // set enum to project to be run
            var projectEnum = CodingExerciseProject.ProjectsCombinationSum;

            // when case matches, call method in corresponding project class
            // - add class to "Projects" folder that will perform the actual function call to the
            //   library.
            switch (projectEnum)
            {
                case CodingExerciseProject.ProjectsCombinationSum:
                    CombinationSum.CallCombinationSumProject();
                    break;
                default:  // just a reminder to set the enum!
                    Console.Write("No project was selected.  Select the proper enum to begin.");
                    break;
            }
            Console.ReadLine();
        }

    }
}
