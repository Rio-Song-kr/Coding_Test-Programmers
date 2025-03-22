using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        for(int i = 0; i < my_string.Length; i++)
        {
            switch(my_string[i])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    continue;
                default:
                    answer += my_string[i];
                    break;
            }
        }
        return answer;
    }
}