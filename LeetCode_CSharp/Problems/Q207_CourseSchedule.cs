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
            var graph = new List<int>[numCourses];

            foreach (var prerequisite in prerequisites)
            {
                if (prerequisite[0] == prerequisite[1]) return false;

                if (graph[prerequisite[1]] == null) graph[prerequisite[1]] = new List<int>();
                graph[prerequisite[1]].Add(prerequisite[0]);
            }
            var seen = new HashSet<int>();

            for (var startIndex = 0; startIndex < numCourses - 1; startIndex++)
            {
                var visited = new HashSet<int>();

                var hasLoop = DFS(startIndex, graph, visited, seen);
                if (hasLoop) return false;
            }
            
            return true;
        }

        private bool DFS(int currentIndex, List<int>[] graph, HashSet<int> visited, HashSet<int> seen)
        {
            if (visited.Contains(currentIndex)) return true;
            if (seen.Contains(currentIndex)) return false;

            seen.Add(currentIndex);

            if (graph[currentIndex] == null) return false;

            foreach (var nextIndex in graph[currentIndex])
            {
                visited.Add(currentIndex);
                var hasLoop = DFS(nextIndex, graph, visited, seen);
                visited.Remove(currentIndex);
                if (hasLoop) return true;
            }

            return false;
        }
    }
}
