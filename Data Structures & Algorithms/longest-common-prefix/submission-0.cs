public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int n = strs.Length;
        int minLen = int.MaxValue;
        for(int i=0;i<n;i++){
            if(strs[i].Length<minLen){
                minLen = strs[i].Length;
            }
        }
        StringBuilder ans = new StringBuilder();
        for(int i=0;i<minLen;i++){
            bool temp = true;
            for(int j=1;j<n;j++){
                if(strs[j][i] != strs[0][i]){
                    temp = false;
                    return ans.ToString();
                }
            }
            if(temp == true){
                ans.Append(strs[0][i]);
            }
        }
        return ans.ToString();
    }
}