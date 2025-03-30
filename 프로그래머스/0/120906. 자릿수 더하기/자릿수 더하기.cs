using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string str = n.ToString();
        
        for(int i = 0; i < str.Length; i++) {
            answer += n % 10;
            n /= 10;
        }
        
        return answer;
    }
}