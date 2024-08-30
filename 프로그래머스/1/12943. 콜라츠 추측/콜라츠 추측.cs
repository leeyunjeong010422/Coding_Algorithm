using System;

public class Solution
{
    public int solution(int num)
    {
        long n = num; // int로 하면 범위 오류 방지
        int answer = 0;

        // 1인 경우 0을 반환
        if (n == 1)
        {
            return 0;
        }

        while (n != 1 && answer < 500) // 1이 아니고 500번 반복보다 적어야 함
        {
            if (n % 2 == 0)
            {
                n /= 2; // 짝수일 때는 2로 나누고
            }
            else
            {
                n = n * 3 + 1; // 홀수일 때는 3을 곱하고 1을 더함
            }
            answer++; // 1씩 증가하며 반복 횟수를 세어줌
        }

        return (n == 1) ? answer : -1; 
    }
}
