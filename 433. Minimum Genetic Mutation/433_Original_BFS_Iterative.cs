public class Solution {
    
    public int MinMutation(string start, string end, string[] bank) {
        //BFS with queue approach   
        //starting with the end and trying to mutate to the start
        var qGene = new Queue<string>();
        var qMutation = new Queue<int>();
        var isEndInBank = false;
        for(var i = 0; i < bank.Length; i++){
            if(end == bank[i]) isEndInBank = true;
        }
        if(!isEndInBank) return -1;
        qGene.Enqueue(end);
        qMutation.Enqueue(0);
        var curGene = "";
        var curMutation = 0;
        while(qGene.Count > 0){
            curGene = qGene.Dequeue();
            curMutation = qMutation.Dequeue();
            if(IsOneMutation(start, curGene))
                return curMutation + 1;
            for(var i = 0; i < bank.Length; i++){
                if(IsOneMutation(bank[i], curGene)){
                    qGene.Enqueue(bank[i]);
                    qMutation.Enqueue(curMutation + 1);
                }
            }
        }
        return -1;
    }
    
    private bool IsOneMutation(string mutation, string origin){
        var mutationCount = 0;
        for(var i = 0; i < 8; i++){
            if(mutationCount > 1) return false;
            if(mutation[i]!= origin[i])
                mutationCount++;
        }
        return mutationCount == 1;
    }
}