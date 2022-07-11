using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Q207_CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var graph = new List<List<int>>(numCourses);

            foreach (var prerequisite in prerequisites)
            {
                if (graph[prerequisite[0]] == null) graph[prerequisite[0]] = new List<int>();
                graph[prerequisite[0]].Add(prerequisite[1]);
            }

            var firstCourseIndex = -1;

            for (var index = 0; index < graph.Count; index++)
            {
                if (graph[index] == null)
                {
                    firstCourseIndex = index;
                    break;
                }
            }



        }
    }
}
