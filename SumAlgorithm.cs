//[?]목표: n명의 국어점수 중에서 80점 이상인 점수의 합계
using System;

/// <summary>
/// 합계 알고리즘(Sum Algorithm) ; 주어진 범위에 주어진 조건에 해당하는 자료의 합계
/// </summary>
class SumAlgorithm
{
    static void Main()
    {//알고리즘 = 문제해결능력. =>1. Input :어떤 자료가 주어지느냐, 2. Process : 어떻게 처리하느냐, 3. Output : 결과물이 무엇이냐.
     ////이 중 2번 Process가 알고리즘 영역, 1. Input은 자료구조영역(배열, 변수, 리스트...무엇에 들어있느냐.)3.은 어디에..C# 콘솔에서!
        //[1] Input  : n명의 국어 점수
        int[] scores = { 100, 75, 50, 37, 90, 95 };//정수형 배열
        int sum = 0;

        //[2] Process : 주어진 범위에 주어진 조건을 잘 살핀다.
        //반복문과 조건문을 얼마나 잘 쓰냐가 중요하다.
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > 80)
            {
                sum += scores[i];//score의 i순번의 값이 80보다 크면 sum에 추가한다.
            }
        }

        //[3] Output
        Console.WriteLine($"{scores.Length}명의 점수중 80점 이상의 총점 : {sum} ");
    }
    // (new int[] {95,85,45,27,54,90}).Where(s => s >= 80).sum(); : Expression문으로 sum구하기
}