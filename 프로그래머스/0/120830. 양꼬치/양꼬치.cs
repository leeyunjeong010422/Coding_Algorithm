using System;

public class Solution {
    public int solution(int n, int k) {    
        int a = 0;
        int b = 0;
        int s = 0;
        a = n * 12000;
        b = k * 2000;
        
        if (n>=10) {            
            s = (n / 10) * 2000;
        }
        
        int answer = a+(b-s);
        return answer;
    }
}