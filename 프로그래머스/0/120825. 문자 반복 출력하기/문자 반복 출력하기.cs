using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        foreach(var oneChar in my_string) {
            answer += new string(oneChar, n);
        }
        return answer;
    }
}