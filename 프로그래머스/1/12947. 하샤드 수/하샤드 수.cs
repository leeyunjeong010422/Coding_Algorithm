public class Solution {
    public bool solution(int x) {
        //자릿수끼리의 합
        int sum = 0;
        
        //각 자릿수를 더하기
        int temp = x;
        while (temp > 0) {
            sum += temp % 10; // 마지막 자릿수 추가해서 sum에 더함
            // %10을 하면 temp의 마지막 수를 얻을 수 있음
            //temp가 123일 때 123 % 10은 3, 12 % 10은 2 이런식으로
            
            temp /= 10; // 마지막 자릿수 제거
            // /10을하면 마지막수를 제거할 수 있음
            //temp가 123일 때 123 / 10은 12, 12 / 10은 1 이런식으로
        }
        
        // x가 하샤드인지 아닌지 알려면 각 자릿수의 합으로 나누어 떨어져야 함
        // x(입력된 수) % sum (위에서 진행한 x의 모든 자릿수의 합) == 0 (나누어 떨어지는 거니까 0)
        return x % sum == 0;
    }
}