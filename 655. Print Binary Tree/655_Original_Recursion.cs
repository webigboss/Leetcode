public class Solution {
    public IList<IList<string>> PrintTree(TreeNode root) {
        //get the height first, the row of the matrix is height, column is Pow(2, height) - 1;
        int row = GetHeight(root);
        int col = (int)Math.Pow(2, row) - 1; 
        var ans = new string[row][];
        for(var i = 0; i < ans.Length; ++i){
            ans[i] = new string[col];
            Array.Fill(ans[i], string.Empty);
        }

        Helper(root, 0, col-1, 0, ans);
        return ans;
    }
    
    private void Helper(TreeNode root, int l, int r, int height, IList<IList<string>> list){
        if(root == null) return;
        var icenter = (l + r) / 2;
        list[height][icenter] = root.val.ToString();
        Helper(root.left, l, icenter - 1, height + 1, list);
        Helper(root.right, icenter + 1, r, height + 1, list);
    }
    
    private int GetHeight(TreeNode root){
        if(root == null) return 0;
        return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
    }
}


public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        var ans = new List<int>();
        var maxCol = 0;
        var curRow = 0;
        var r = 0;
        var c = 0;
        foreach(var n in nums)
            maxCol = Math.Max(maxCol, n.Count);
        var maxRow = nums.Count + maxCol - 1;
        
        while(curRow < maxRow){
            if(r <= nums.Count - 1 && c <= nums[r].Count - 1)
                ans.Add(nums[r][c]);
            r--;
            c++;
            if(r == -1){
                r = ++curRow;
                c = 0;
            }
        }
        return ans.ToArray();
        
    }
}