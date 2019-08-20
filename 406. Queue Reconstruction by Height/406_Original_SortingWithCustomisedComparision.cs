public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
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