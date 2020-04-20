public class Solution {
    public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4) {
        var s1 = SqrDistSum(p1, p2, p3, p4);
        if(s1 == -1) return false;
        var s2 = SqrDistSum(p2, p1, p3, p4);
        if(s2 != s1) return false;
        var s3 = SqrDistSum(p3, p1, p2, p4);
        if(s3 != s1) return false;
        var s4 = SqrDistSum(p4, p1, p2, p3);
        if(s4 != s1) return false;
        return true;
    }
    
    private int SqrDistSum(int[] pFrom, int[] pTo1, int[] pTo2, int[] pTo3){
        var sum = 0;
        var dis1 = SqrDist(pFrom, pTo1);
        if(dis1 == 0) return -1;
        var dis2 = SqrDist(pFrom, pTo2);
        if(dis2 == 0) return -1;
        var dis3 = SqrDist(pFrom, pTo3);
        if(dis3 == 0) return -1;
        sum = dis1 + dis2 + dis3;
        if(dis1*2 != sum && dis1*4 != sum) return -1;
        if(dis2*2 != sum && dis2*4 != sum) return -1;
        if(dis3*2 != sum && dis3*4 != sum) return -1;
        return sum;
    }
    
    private int SqrDist(int[] p1, int[] p2){
        return (int)(Math.Pow(Math.Abs(p1[0]-p2[0]), 2) + Math.Pow(Math.Abs(p1[1]-p2[1]), 2));
    }
}  