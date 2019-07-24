using System.Collections.Generic;
using System.Text;
namespace AlgorithmPlayground{
    public class FindSubStringClass {

        public FindSubStringClass(){
            var s = "barfoothefoobarma";
            var words = new []{"foo", "bar"};
            var result = FindSubstring(s, words);
        }
        public IList<int> FindSubstring(string s, string[] words) {
            var result = new List<int>();
            if(words.Length == 0) return result;
            var length = words[0].Length;
            var expected = new Dictionary<string, int>();
            var actual = new Dictionary<string, int>();
            var sb = new StringBuilder();
            for(var i = 0; i < words.Length; i++){
                if(expected.ContainsKey(words[i]))
                    expected[words[i]]++;
                else
                    expected[words[i]] = 1;
            }
            
            for(var i = 0; i < s.Length - length * words.Length + 1; i++){
                var counter = 0;
                var total = 0;
                for(var j = i; j < s.Length; j++){
                    sb.Append(s[j]);
                    counter++;
                    if(counter == length){
                        var word = sb.ToString();
                        if(expected.ContainsKey(word)){
                            if(!actual.ContainsKey(word)){
                                actual[word] = 1;
                                total++;
                            }
                            else if(actual.ContainsKey(word)){
                                if(actual[word] < expected[word]){
                                    actual[word]++;
                                    total++;
                                }
                                else{
                                    actual.Clear();
                                    sb.Clear();
                                    break;
                                }
                            }
                        }
                        else{
                            actual.Clear();
                            sb.Clear();
                            break;
                        }
                        if(total == words.Length){
                            result.Add(i);
                            actual.Clear();
                            sb.Clear();
                            break;
                        }
                        sb.Clear();
                        counter = 0;
                    }

                }
            }
            return result;
        }
    }
}