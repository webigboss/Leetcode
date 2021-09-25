using System;
using System.Collections.Generic;
using System.Linq;

public class CourseSelecting {
    public void Test_SameCourceBetweenTwo(){
        var selections = new List<string[]>{
            new []{"23", "Economy"},
            new []{"12", "English"},
            new []{"12", "Economy"},
            new []{"23", "Biology"},
            new []{"55", "Chemistry"}
        };
        var result = SameCourseBetweenTwo(selections);
        foreach(var e in result) {
            Console.WriteLine($"{e.Item1}: [{string.Join(',', e.Item2)}]");
        }
        var result2 = SameCourseBetweenTwoOptimized(selections);
        foreach(var kvp in result2) {
            Console.WriteLine($"{kvp.Key}: [{string.Join(',', kvp.Value)}]");
        }
    }

    public List<Tuple<string, List<string>>> SameCourseBetweenTwo(List<string[]> selections) {
        var dict = new Dictionary<string, HashSet<string>>();
        foreach(var s in selections){
            if(!dict.ContainsKey(s[0]))
                dict[s[0]] = new HashSet<string>();
            dict[s[0]].Add(s[1]);
        }
        var idList = new List<string>(dict.Keys);
        var ans = new List<Tuple<string, List<string>>>();
        for(var i = 0; i < idList.Count; ++i){
            var iset = dict[idList[i]];
            for(var j = i+1; j < idList.Count; ++j){
                var jset = dict[idList[j]];
                var pair = $"{idList[i]},{idList[j]}";
                var courses = new List<string>();
                foreach(var course in jset){
                    if(iset.Contains(course)){
                        courses.Add(course);
                    }
                }
                ans.Add(new Tuple<string, List<string>>(pair, courses));
            }
        }
        return ans;
    }

    public List<KeyValuePair<string, List<string>>> SameCourseBetweenTwoOptimized(List<string[]> selections){
        var dict = new Dictionary<string, List<string>>();
        foreach(var s in selections) {
            if(!dict.ContainsKey(s[1])){
                dict[s[1]] = new List<string>();
            }
            dict[s[1]].Add(s[0]);
        }
        var ansDict = new Dictionary<string, List<string>>();

        foreach(var kvp in dict){
            var k = kvp.Key;
            var v = new List<string>(kvp.Value);
            if(v.Count <= 1) continue;
            v.Sort();
            for(var i = 0; i < v.Count; i++){
                for(var j = i+1; j < v.Count; j++){
                    var namePair = $"{v[i]},{v[j]}";
                    if(!ansDict.ContainsKey(namePair))
                        ansDict[namePair] = new List<string>();
                    ansDict[namePair].Add(k);
                }
            }
        }
        // To-do: adding all the pairs that doesn't have shared courses
        // need to have a set of all the student, create a list from it and sort it, then iterate n^2 to find the missing pairs
        return ansDict.ToList(); 
    }


}