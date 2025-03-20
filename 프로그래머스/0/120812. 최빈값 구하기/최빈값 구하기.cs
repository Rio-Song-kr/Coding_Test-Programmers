using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int maxCount = 0;
        
        
        if(array.Length == 1) {
            return array[0];
        }
        
        var uniqueArray = array.Distinct().ToArray();
        int[] count = new int[uniqueArray.Length];
        
        for(int i = 0; i < uniqueArray.Length; i++) {
            count[i] = array.Count(value => value == uniqueArray[i]);
        }
        
        for(int i = 0; i < count.Length; i++) {
            if(maxCount == count[i])
            {
                maxCount = count[i];
                answer = -1;
            }
            
            else if(maxCount < count[i]) {
                maxCount = count[i];
                answer = uniqueArray[i];
            }
        }
        
        
        return answer;
    }
}