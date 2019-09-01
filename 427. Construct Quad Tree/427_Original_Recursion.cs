/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node(){}
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
}
*/
public class Solution {
    public Node Construct(int[][] grid) {
        if(grid.Length == 0 || grid[0].Length == 0)
            return null;
        return ConstructRecursive(grid, 0, grid[0].Length - 1, 0, grid.Length - 1);
    }
    
    private Node ConstructRecursive(int[][] grid, int xlo, int xhi, int ylo, int yhi){
        var node = new Node();
        node.isLeaf = IsLeaf(grid, xlo, xhi, ylo, yhi, out var val);
        if(node.isLeaf)
            node.val = val;
        else{
            node.topLeft = ConstructRecursive(grid, xlo, (xlo + xhi)/2, ylo, (ylo + yhi)/2);
            node.topRight = ConstructRecursive(grid, (xlo + xhi)/2 + 1, xhi, ylo, (ylo + yhi)/2);
            node.bottomLeft = ConstructRecursive(grid, xlo, (xlo + xhi)/2, (ylo + yhi)/2 + 1, yhi);
            node.bottomRight = ConstructRecursive(grid, (xlo + xhi)/2 + 1, xhi, (ylo + yhi)/2 + 1, yhi);
        }
        return node;
    }
    
    private bool IsLeaf(int[][] grid, int xlo, int xhi, int ylo, int yhi, out bool val){
        var isLeaf = true;
        var initialValue = grid[ylo][xlo];
        val = false;
       
        for(var y = ylo; y <= yhi; y++){
            for(var x = xlo; x <= xhi; x++){
                if(initialValue != grid[y][x]){
                    isLeaf = false;
                    break;
                }
            }
        }
        if(isLeaf){
            val = initialValue == 1;
        }
        return isLeaf;
    }
}