using System.Collections.Generic;

namespace AlgorithmPlayground
{
    //https://leetcode.com/discuss/interview-question/347457
    public class TreasureIsland
    {
        public TreasureIsland()
        {
            var map = new[]{
                new []{'0','0','0','0'},
                new []{'D','0','D','0'},
                new []{'0','0','0','0'},
                new []{'X','D','D','0'},
            };
            var minStep = FindTreasure(map);
        }

        public int FindTreasure(char[][] map)
        {
            var neighbours = new[]{
                new[]{0, 1},
                new[]{0, -1},
                new[]{1, 0},
                new[]{-1, 0}
            };
            var q = new Queue<int[]>();
            q.Enqueue(new[] { 0, 0, 0 });
            var ly = map.Length;
            var lx = map[0].Length;
            int x, y, step;
            while (q.Count > 0)
            {
                var item = q.Dequeue();
                x = item[0];
                y = item[1];
                step = item[2];
                if(map[y][x] == 'D') continue;
                map[y][x] = 'D';
                foreach (var n in neighbours)
                {
                    if (x + n[0] >= 0 && x + n[0] < lx && y + n[1] >= 0 && y + n[1] < ly)
                    {
                        if(map[y + n[1]][x + n[0]] == 'D') continue;
                        if(map[y + n[1]][x + n[0]] == 'X') {
                            return step + 1;
                        }
                        q.Enqueue(new []{x + n[0], y + n[1], step + 1 });
                    }
                }
            }
            return -1;
        }
    }
}