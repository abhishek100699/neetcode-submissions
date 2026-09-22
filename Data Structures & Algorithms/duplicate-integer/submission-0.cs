public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> dt = new Dictionary<int,int>();
        foreach(int x in nums){
            if(dt.ContainsKey(x)){
                dt[x]++;
            }
            else{
                dt[x] = 1;
            }
        }
        foreach(var x in dt){
            if(x.Value >1){
                return true;
            }
        }
        return false;
    }
}