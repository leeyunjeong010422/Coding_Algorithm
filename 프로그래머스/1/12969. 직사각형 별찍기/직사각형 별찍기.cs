using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]); //가로
        int b = Int32.Parse(s[1]); //세로

        // 직사각형 출력
        //b(세로)를 먼저 for문에 작성된 이유
        //행을 결정한 후에 그 행에 출력할 별의 수를 결정해야 해서
        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // 다음 줄로 이동
        }
    }
}