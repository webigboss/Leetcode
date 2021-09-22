using System;
using System.Collections.Generic;

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


}