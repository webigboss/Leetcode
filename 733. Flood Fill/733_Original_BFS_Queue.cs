public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        //BFS with a queue
        var q = new Queue<int[]>();
        int lr = image.Length, lc = image[0].Length, orgColor = image[sr][sc];
        var visited = new bool[lr, lc];
        var directions = new []{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1},
        };
        
        q.Enqueue(new []{sr, sc});
        while(q.Count > 0){
            var item = q.Dequeue();
            var r = item[0];
            var c = item[1];
            if(visited[r,c]) continue;
            visited[r,c] = true;
            image[r][c] = newColor;
            foreach(var d in directions){
                int nr = r+d[0], nc = c+d[1];
                if(nr >= 0 && nr < lr && nc >= 0 && nc < lc && image[nr][nc] == orgColor){
                    q.Enqueue(new []{nr, nc});
                }
            }
        }
        return image;
    }
}