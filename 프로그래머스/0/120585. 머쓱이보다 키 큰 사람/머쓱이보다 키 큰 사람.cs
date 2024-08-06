using System;

public class Solution {
    public int solution(int[] array, int height) {
        int count = 0;
        
        foreach (int num in array) {
            if (num > height) {
                count++;
            }
        }
        
        return count++;
    }
}