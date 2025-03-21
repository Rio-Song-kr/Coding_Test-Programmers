using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        return numbers.Max() * numbers.OrderByDescending(value => value).ToArray()[1];
    }
}