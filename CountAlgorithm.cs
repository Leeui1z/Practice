//[?] 1부터 1000까지의 정수 중 13의 배수의 개수
using System;
using System.Linq;
/// <summary>
/// 개수 알고리즘(CountAlgorithm) : 주어진 범위에 주어진 조건에 해당하는 자료들의 개수
/// </summary>

class CountAlgorithm
{
    static void Main()
    {
        //[1] Input : 1~1000까지의 대이터
        var numbers = Enumerable.Range(1, 1_000).ToArray();//본래 int [] numbers였는데 Enumerable이 int형, Range로 범위를 넣고 Array를 이용해 배열로 만든다.
        //1000을 표현할때 , 대신 _를 넣는다. 개수는 상관x
        int count = 0;//0으로 초기화(기본치니 default로 하기도.)

        //[2] Process : 개수 알고리즘 영역 : 주어진 영역에 주어진 조건(필터링)
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 13 == 0)
            {
                
                count++;//== count += 1;
            }
        }
        //[3] Output
        Console.WriteLine($"1부터 1,000까지의 정수 중 13의 배수의 개수 : {count}");
    }
}
//Enumerable.Range(1,1_000).ToArray().Where(n => n % 13==0).Count() whrer은 조건문, count()에 넣어도 무관
//Enumerable.Range(1,1_000).ToArray().Count(n => n % 13==0)