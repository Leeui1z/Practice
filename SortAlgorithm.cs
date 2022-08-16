//[?] 무작위 데이터를 순서대로 [오름차순/내림차순]정렬
using System;
/// <summary>
/// 정렬 알고리즘: 가장 작은/큰 데이터를 왼쪽으로 순서대로->오름차순 내림차순 
/// </summary>

class SortAlgorithm
{
    static void Main()
    {
        //[1] Input : Data Structure(array, list, stack, queue...)
        int[] data = { 3, 2, 1, 4, 5 };
        int N = data.Length;//의사코드(슈도코드)형태로 알고리즘을 표현하기 위함
        //의사코드 : 특정 프로그래밍 언어가 아닌 순서도처럼 i는 어디부터 N까지..단어로 의사를 표현함

        //[2] Process : Selection Sort 선택정렬 알고리즘
        for (int i = 0; i < N-1; i++)//i=0 to N-1
        {
            for (int j = i+1; j < N; j++)//j = i +1 to N
            {
                if (data[i] > data[j])//부등호 방향 : 오름차순 >, 내림차순 <
                {
                    int temp = data[i]; data[i] = data[j]; data[j] = data[temp];//i와 j 값이 Swap된다
                    //i번째가 크면 i와 j 순서를 바꿔 작은것이 왼쪽으로 가도록,오름차순으로 만든다.
                }
            }
        }

        //[3] Output : console, desktop, web, mobile
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{data[i]}");
        }
        Console.WriteLine();
    }
}
//[1] Input : 
//[2] Process : 
//[3] Output : 
//Array.Sort(data);
//var sort = data.OrderBy(n => n).ToArray();