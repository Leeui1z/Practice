//[?] 주어진 데이터 중에서 가장 큰 값
using System;
using System.Linq;
/// <summary>
/// 최댓값 알고리즘 (Max Algorithm) : (주어진 범위+주어진 조건)의 자료들의 가장 큰 값
/// </summary>
class MaxAlgorithm
{
    static void Main()
    {
        //[1] initialize(초기화) 최댓값은 정수 형식 데이터 중 최솟값으로 초기화 시켜준다.
        int max = int.MinValue; 

        //[2] Input
        int[] numbers = { -2, -5, -3, -7, -1 };

        //[3] Process : Max
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]>max)//주어진 범위에 가장 작은 값을 할당한 것보다 큰 값이 있으면 
            {
                max = numbers[i];//큰 값으로 할당한다. => MAX
            }
        }

        //[4] Output 
        Console.WriteLine($"최댓값(식) : {numbers.Max()}");//linq 이용
        Console.WriteLine($"최댓값(문) : {max}");


    }
}
