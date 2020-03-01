public class Solution {
    public int[] ConstructRectangle(int area) {
        var w = (int)Math.Sqrt(area); // cast to in will truncate, like Math.Floor()
        while(area % w != 0)
            w--;
        return new []{ area / w, w };
    }
}