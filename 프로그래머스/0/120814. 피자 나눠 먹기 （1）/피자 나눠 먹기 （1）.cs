using System;

public class Solution {
    public int solution(int n) {
        
        int result = 0;
        int pizzaCount = 7;
        
        if (n <= 7) {
            result = 1;
        }
        else if(n % pizzaCount == 0) {
            result = n / pizzaCount;
            }
            else if (n % pizzaCount <= 6) {
             result = (n / pizzaCount) + 1;
            }
        Console.WriteLine(result);
        return result;
    }
}