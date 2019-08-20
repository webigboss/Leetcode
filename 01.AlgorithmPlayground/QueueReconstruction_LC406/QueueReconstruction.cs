using System;
namespace AlgorithmPlayground
{
    public class QueueReconstruction
    {
        public QueueReconstruction()
        {
            var people = new[]{
                new []{7,0},
                new []{4,4},
                new []{7,1},
                new []{5,0},
                new []{6,1},
                new []{5,2},
            };
            var result = ReconstructQueue(people);
        }
        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, new Comparison<int[]>(
                (x, y) =>
                {
                    if (x[0] < y[0]) return -1;
                    else if (x[0] > y[0]) return 1;
                    else
                    { // x[0] == y[0]
                        if (x[1] < y[1]) return -1;
                        else if (x[1] > y[1]) return 1;
                        else return 0;
                    }
                }
            ));
            var result = new int[people.Length][];
            for (var i = 0; i < people.Length; i++)
            {
                var step = 0;
                var index = 0;
                while (true)
                {
                    if (step == people[i][1])
                    {
                        if (result[index++] != null) continue;
                        break;
                    }
                    if (result[index] == null || result[index][0] >= people[i][0]) step++;
                    index++;
                }
                result[index - 1] = people[i];
            }
            return result;
        }

    }
}