public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int [] pre = new int [n];
        int [] post = new int [n];
        int preProd = 1, postProd = 1;
        for(int i=0;i<n;i++){
            preProd = preProd*nums[i];
            postProd = postProd*nums[n-i-1];
            pre[i] = preProd;
            post[n-i-1] = postProd;
        }

        for(int i=0;i<n;i++){
            int temp = 1;
            if(i-1 >= 0){
                temp = temp*pre[i-1];
            }
            if(i+1<n){
                temp = temp*post[i+1];
            }
            nums[i] = temp;
        }
        return nums;
    }
}
