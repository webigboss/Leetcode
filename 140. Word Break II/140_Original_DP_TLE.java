class Solution {
    public List<String> wordBreak(String s, List<String> wordDict) {
        //DP approach
        Map<Integer, ArrayList<String>> dp = new HashMap<Integer, ArrayList<String>>();
        dp.put(0, new ArrayList<String>(Arrays.asList("")));
        Set hs = new HashSet<String>();
        for(String word : wordDict)
            hs.add(word);
        StringBuilder sb = new StringBuilder();
        for(Integer i = 0; i < s.length(); i++){
            if(dp.containsKey(i)){
                sb.setLength(0);
                for(Integer j = i; j < s.length(); j++){
                    sb.append(s.charAt(j));
                    var cur = sb.toString();
                    if(hs.contains(cur)){
                        if(!dp.containsKey(j + 1))
                            dp.put(j + 1, new ArrayList<String>());
                        for(String prev : dp.get(i)){
                            dp.get(j + 1).add(prev.isEmpty() ? cur : prev + " " + cur);
                        }
                    }
                }
            }
        }
        return dp.containsKey(s.length()) ? dp.get(s.length()) : new ArrayList<String>();
    }
}