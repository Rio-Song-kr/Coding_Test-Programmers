using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        return new int[2]
        {
            num_list.Count(value => value % 2 == 0),
            num_list.Count(value => value % 2 == 1),
        };
    }
}