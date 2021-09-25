using System;
using System.Collections.Generic;
using System.Text;

public class WordWrap
{

    public void Test_WrapWord()
    {
        var words1 = new string[]{
            "The", "day", "began", "as", "still", "as", "the",
            "night", "abruptly", "lighted", "with", "brilliant","flame"
        };
        var words2 = new string[] { "Hello" };
        var words3 = new string[] { "Hello", "World" };
        var words4 = new string[] { "Well", "Hello", "world" };
        var words5 = new string[] { "Hello", "HelloWorld", "Hello", "Hello" };
        var ans = WrapWord(words1, 13);
        ans = WrapWord(words1, 20);
        ans = WrapWord(words2, 5);
        ans = WrapWord(words3, 5);
        ans = WrapWord(words4, 5);
        ans = WrapWord(words5, 20);

    }
    private void PrintResult(List<string> ans)
    {
        for (var i = 0; i < ans.Count; i++)
        {
            var cur = $"\"{ans[i]}\"";
            if (i == 0) cur = "[" + cur;
            if (i == ans.Count - 1) cur = cur + "]";
            Console.WriteLine(cur);
        }
    }
    public List<string> WrapWord(string[] words, int maxLen)
    {
        var ans = new List<string>();
        int n = words.Length;
        string cur = words[0];
        for (var i = 1; i < n; ++i)
        {
            if (cur.Length + words[i].Length + 1 <= maxLen)
            {
                cur += "-" + words[i];
            }
            else
            {
                ans.Add(cur);
                cur = words[i];
            }

            if (i == n - 1)
                ans.Add(cur);
        }
        PrintResult(ans);
        Console.WriteLine("---");
        return ans;
    }

    public void Test_BalanceWordWrap()
    {
        var words1 = new string[] { "123 45 67 8901234 5678", "12345 8 9 0 1 23" };
        var words2 = new string[] { "123 45 67 8901234 5678", "12345 8 9 0 1 23" };
        var ans = BalanceWrapWord(words1, 10);
        PrintResult(ans);
        ans = BalanceWrapWord(words2, 15);
        PrintResult(ans);
    }
    public List<string> BalanceWrapWord(string[] words, int maxLen)
    {
        int len = 0;
        var list = new List<string>();
        var ans = new List<string>();
        var wordList = new List<string>();
        foreach (var word in words)
        {
            foreach (var w in word.Split(" "))
            {
                wordList.Add(w);
            }
        }
        int n = wordList.Count;
        Console.WriteLine(string.Join(',', wordList));
        //words ["123 45 67 8901234 5678", "12345 8 9 0 1 23"]
        for (var i = 0; i < n; ++i)
        {
            if (len + wordList[i].Length + list.Count > maxLen)
            {
                int cntSp = maxLen - len;
                if (list.Count > 1)
                {
                    int lenSp = cntSp / (list.Count - 1);
                    int cntRe = cntSp % (list.Count - 1);
                    var sb = new StringBuilder();
                    for (var j = 0; j < list.Count; ++j)
                    {
                        sb.Append(list[j]);
                        if (j < list.Count - 1)
                        {
                            sb.Append(new string('-', lenSp));
                            if (cntRe-- > 0)
                                sb.Append('-');
                        }
                    }
                    ans.Add(sb.ToString());
                }
                else
                {
                    ans.Add(list[0]);
                }
                list.Clear();
                list.Add(wordList[i]);
                len = wordList[i].Length;
            }
            else
            {
                list.Add(wordList[i]);
                len += wordList[i].Length;
            }

            if (i == n - 1)
            {
                int cntSp = maxLen - len;
                if (list.Count > 1)
                {
                    int lenSp = cntSp / (list.Count - 1);
                    int cntRe = cntSp % (list.Count - 1);
                    var sb = new StringBuilder();
                    for (var j = 0; j < list.Count; ++j)
                    {
                        sb.Append(list[j]);
                        if (j < list.Count - 1)
                        {
                            sb.Append(new string('-', lenSp));
                            if (cntRe-- > 0)
                                sb.Append('-');
                        }
                    }
                    ans.Add(sb.ToString());
                }
                else
                {
                    ans.Add(list[0]);
                }
                list.Clear();
                list.Add(wordList[i]);
                len = wordList[i].Length;
            }
        }
        return ans;
    }


}