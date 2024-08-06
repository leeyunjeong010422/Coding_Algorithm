using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        var answerList = new List<int>();
        
        for(int i = 1; i <= n; i++) {
            if(i % 2 != 0) {
                answerList.Add(i);
            }
        }
        
        return answerList.ToArray();
    }
}