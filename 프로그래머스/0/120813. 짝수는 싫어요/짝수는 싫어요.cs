using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[n / 2 + n % 2];
        for(int i = 1; i <= n; i += 2) {
            answer[ i / 2] = i;
        }
        return answer;
    }
}