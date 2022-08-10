//[?]원본 데이터 주에서 대상 데이터와 가장 가까운 값
using System;
using System.Linq;
using static System.Console;
using static System.Math;

/// <summary>
/// 근사값 알고리즘(Near Algorithm) : 차잇값의 절댓값의 최솟값
/// </summary>
class MyClass
{
    static void Main()
    {
        //[0] 절댓값 구하기 로컬함수 : Math.Abs()함수와 동일한 기능을 구현한 것
        int Abs(int number) => (number < 0) ? -number : number;
        //정수형 number을 넘겨주면 int를 반환하는 Abs 함수 (num이 0보다 작으면 "-num", 크면 num)

        //[1] Initailize 
        int min = int.MaxValue; //차잇값의 절댓값의 최솟값이 담길 그릇

        //[2] Input
        int[] numbers = { 10, 20, 30, 27, 17 };
        int target = 25;
        int near = default;//target과 가까운 값이 담긴다.

        //[3] Process : 근삿값 Algrothm
        for (int i = 0; i < numbers.Length; i++)
        {
            int abs = Abs(numbers[i] - target);//차잇값의 절댓값
            if (abs<min)
            {
                min = abs;//차잇값에 MIN 최솟값 알고리즘
                near = numbers[i];//차잇값의 절댓값의 최솟값 => 근삿값 알고리즘
            }
        }

        //[4] Output
        Console.WriteLine($"25와 가장 가까운 값(식): {min}(차이 : {min-target})");
        var minimum = numbers.Min(m => Math.Abs(m-target));//차잇값의 최솟값
        var closet = numbers.First(n => Abs(n - target) == minimum);//근사값
        WriteLine($"{target}와 가장 가까운 값(식): {closet}(차이 : {minimum})");
        WriteLine($"{target}와 가장 가까운 값(문): {near}(차이 : {min})");// for, if문


        //numbers.First(n=>Math.Abs(n-target) == numbers.Min(m=>Math.Abs(m-target)))
    }
}
