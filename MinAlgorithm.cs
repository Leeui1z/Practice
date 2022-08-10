//[?] 주어진 데이터 중에서 가장 작은"짝수" 값
using System;
using System.Linq;
using static System.Console;
/// <summary>
/// 최솟값 알고리즘 (Min Algorithm) : (주어진 범위+주어진 조건)의 자료들의 가장 작은 값
/// </summary>
class MinAlgorithm
{
    static void Main()
    {
        //[1] initialize(초기화) 최솟값은 정수 형식 데이터 중 최댓값으로 초기화 시켜준다.
        int min = Int32.MaxValue;

        //[2] Input
        //int[] numbers = { 2, 5, 3, 7, 1 };
        int[] numbers = { 0b_0001, 0b_0010, 0b0101,0b0011,0b0111 };//이진수로 표현+숫자 구분자


        //[3] Process : Min
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]<min && numbers[i]%2==0)//주어진 범위에 가장 큰 값을 할당한 것보다 작은 값이 있으면 
            {
                min = numbers[i];//작은 값으로 할당한다. => Min
            }
        }

        //[4] Output 
        Console.WriteLine($"짝수 최솟값(식) : {numbers.Where(n => n % 2==0).Min()}");//linq 이용
        WriteLine($"최솟값(문) : {min}");


    }
}
