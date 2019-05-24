public class Solution {
     public void Solve(char[][] board)
        {
            //global hashset that stores visited element, bool value stands for whether it's been captured. so default is false;
            var visited = new HashSet<string>();


            for (var y = 0; y < board.Length; y++)
            {
                for (var x = 0; x < board[0].Length; x++)
                {
                    var key = x + "," + y;
                    if (board[y][x] == 'X' || visited.Contains(key)) // if it's visited, then skip it no matter if it's captured or not
                        continue;
                    SearchAndCapture(board, x, y, visited);
                }
            }

        }

        private void SearchAndCapture(char[][] board, int x, int y, HashSet<string> visited)
        {
            var key = string.Empty;
            var capture = true;
            // record visited element for a single round of search
            var curVisitDict = new Dictionary<string, bool>();
            // queue for performing breadth first search
            var q = new Queue<string>();
            q.Enqueue(x + "," + y);

            while (q.Count > 0)
            {
                key = q.Dequeue();
                if (visited.Contains(key))
                    continue;
                visited.Add(key);
                curVisitDict.Add(key, true);
                x = int.Parse(key.Split(',')[0]);
                y = int.Parse(key.Split(',')[1]);
                if (x == board[0].Length - 1 || x == 0 || y == board.Length - 1 || y == 0)
                    capture = false;
                //up
                if (y > 0)
                {
                    if (board[y - 1][x] == 'O' && !curVisitDict.ContainsKey(x + "," + (y - 1)))
                        q.Enqueue(x + "," + (y - 1));
                }
                //down
                if (y < board.Length - 1)
                {
                    if (board[y + 1][x] == 'O' && !curVisitDict.ContainsKey(x + "," + (y + 1)))
                        q.Enqueue(x + "," + (y + 1));
                }
                //left
                if (x > 0)
                {
                    if (board[y][x - 1] == 'O' && !curVisitDict.ContainsKey((x - 1) + "," + y))
                        q.Enqueue((x - 1) + "," + y);
                }
                //right
                if (x < board[0].Length - 1)
                {
                    if (board[y][x + 1] == 'O' && !curVisitDict.ContainsKey((x + 1) + "," + y))
                        q.Enqueue((x + 1) + "," + y);
                }
            }

            if (capture)
            {//capture by flipping the value to x
                foreach (var k in curVisitDict.Keys)
                    board[int.Parse(k.Split(',')[1])][int.Parse(k.Split(',')[0])] = 'X';
            }

        }
}