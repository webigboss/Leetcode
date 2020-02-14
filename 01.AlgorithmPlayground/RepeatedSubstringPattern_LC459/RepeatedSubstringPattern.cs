
namespace AlgorithmPlayground
{
    public class RepeatedSubstringPatternClass
    {

        public RepeatedSubstringPatternClass()
        {
            var s = "abab";
            var result = RepeatedSubstringPattern(s);
        }
        public bool RepeatedSubstringPattern(string s)
        {
            //brute force
            if (s == null) return false;
            var matchFailed = false;
            for (var l = 1; l <= s.Length / 2 + 1; l++)
            {
                if (l % s.Length != 0) continue;
                matchFailed = false;
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] != s[i % l])
                    {
                        matchFailed = true;
                        break;
                    }
                }
                if (matchFailed == true) continue;
                return true;
            }
            return false;
        }
    }
}