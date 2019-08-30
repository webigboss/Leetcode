using System;

namespace AlgorithmPlayground
{
    public class LongestRepeatingCharacterReplacement
    {
        public LongestRepeatingCharacterReplacement()
        {
            var s = "AABABBCCBABDBABCDDBSBAVBDDBCCCCCABABAB";
            var k = 8;
            var result = CharacterReplacement(s, k);
        }
        public int CharacterReplacement(string s, int k)
        {
            int left = 0, right = 0, count = 0, maxLength = 0;
            var charCounts = new int[26];
            charCounts[s[0] - 'A']++;
            while (right < s.Length)
            {
                count = GetReplaceCount(charCounts);
                if (count > k)
                { // move the left pointer to right and decrease the counter
                    charCounts[s[left] - 'A']--;
                    left++;
                }
                else if (count <= k)
                { // move the right pointer to right and increase the counter 
                    if(count == k)
                        maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                    if (right < s.Length)
                        charCounts[s[right] - 'A']++;
                }
            }
            return maxLength;
        }

        private int GetReplaceCount(int[] charCounts)
        {
            int sum = 0, maxCharCount = 0;
            for (var i = 0; i < charCounts.Length; i++)
            {
                sum += charCounts[i];
                maxCharCount = Math.Max(maxCharCount, charCounts[i]);
            }
            return sum - maxCharCount;
        }
    }
}