using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {        
        
        var answerSort = strings
            .OrderBy(word => word[n]) 
            .ThenBy(word => word) 
            .ToArray();
        
        return answerSort;
    }
}