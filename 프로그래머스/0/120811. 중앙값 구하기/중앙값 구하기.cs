using System;

public class Solution {
    public int solution(int[] array) {
        for(int i = 0; i < array.Length -1; i++) {
            for(int j = i + 1; j < array.Length; j++) {
                if(array[i] > array[j]) {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        
        return array[array.Length / 2];
    }
}