using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array, int n) {
        int count = 0;
    
        foreach (int num in array) {
            if (num == n) { // num이 n과 같으면
                count++; // count 증가
            }
        }
        
        return count;
    }
}