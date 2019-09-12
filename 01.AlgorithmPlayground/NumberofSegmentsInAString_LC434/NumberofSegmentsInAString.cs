namespace AlgorithmPlayground
{
    public class NumberofSegmentsInAString
    {
        public NumberofSegmentsInAString(){
            var a = " a b c ";
            var result = CountSegments(a);
        }
        public int CountSegments(string s)
        {
            var prevChar = '\0';
            var result = 0;
            foreach (var c in s)
            {
                if (c != '\0' && prevChar == '\0')
                    result++;

                prevChar = c;
            }
            return result;
        }
    }
}