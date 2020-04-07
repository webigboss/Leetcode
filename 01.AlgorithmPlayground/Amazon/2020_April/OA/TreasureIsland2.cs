using System;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    //https://leetcode.com/discuss/interview-question/356150
    public class TreasureIsland2
    {
        public TreasureIsland2()
        {
            var map = new[]{
                new [] {'S', 'O', 'O', 'S', 'S'},
                new [] {'D', 'O', 'D', 'O', 'D'},
                new [] {'O', 'O', 'O', 'O', 'X'},
                new [] {'X', 'D', 'D', 'O', 'O'},
                new [] {'X', 'D', 'D', 'D', 'O'}
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
            var ly = map.Length;
            var lx = map[0].Length;
            int curx, cury, curStep;
            
            //1. find all starting point
            for(var y = 0; y < ly; ++y){
                for(var x = 0; x < lx; ++x){
                    if(map[y][x] == 'S'){
                        q.Enqueue(new []{x, y, 0});
                    }
                }
            }

            //2 BFS operation on the queue

            while(q.Count > 0)
            {
                var item = q.Dequeue();

                curx = item[0];
                cury = item[1];
                curStep = item[2];
                if(map[cury][curx] == 'D') continue;
                map[cury][curx] = 'D';
                foreach(var n in neighbours){
                    if(curx + n[0] >= 0 && curx + n[0] < lx && cury + n[1] >= 0 && cury + n[1] < ly){
                        if(map[cury + n[1]][curx + n[0]] == 'D') continue;
                        if(map[cury + n[1]][curx + n[0]] == 'X') return curStep + 1;
                        q.Enqueue(new []{curx + n[0], cury + n[1], curStep + 1});
                    }
                }
            }
            return -1;
        }
    }
}