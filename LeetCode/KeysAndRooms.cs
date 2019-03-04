using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    static class KeysAndRooms
    {
        public static bool Solve(IList<IList<int>> rooms)
        {
            var canVisitAll = false;
            var visited = new int[rooms.Count];
            for (var i = 0; i < visited.Count(); i++)
            {
                visited[i] = 0;
            }
            canVisitAll = VisitRooms(rooms, 0, visited);

            return canVisitAll;
        }

        private static bool VisitRooms(IList<IList<int>> rooms, int currRoomIndex, IList<int> visited)
        {
            visited[currRoomIndex]++;

            if (visited[currRoomIndex] > rooms[currRoomIndex].Count)
            {
                return visited.All(v => v != 0);
            }

            if (visited.All(v => v != 0))
            {
                return true;
            }

            for (var i = 0; i < rooms[currRoomIndex].Count; i++)
            {
                var roomToVisit = rooms[currRoomIndex][i];
                var anyNotVisited = visited[roomToVisit] == 0 || rooms[roomToVisit].Any(r => visited[r] < 1);
                if (anyNotVisited)
                {
                    var all = VisitRooms(rooms, rooms[currRoomIndex][i], visited);
                    if (all)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
