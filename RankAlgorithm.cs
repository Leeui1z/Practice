//[?]주어진(지정한) 범위 데이터의 순위(등수)를 구하는 로직
using System;
using System.Linq;

/// <summary>
/// 순위 알고리즘 : 정수 데이터에 대한 순위 구하기
/// </summary>
class RankAlgorithm
{
    static void Main()
    {
        //[1] Input : 
        int[] scores = { 90, 87, 100, 95, 80 };//3,4,1,2,5위 
        int[] rankings = Enumerable.Repeat(1,5).ToArray();//배열 안의 내용 5개를 전부 1으로 초기화, int형 배열이 있으니까 ToArray을 이용해 배열로 변환

        //[2] Process : Rank
        for (int i = 0; i < scores.Length; i++)
        {
            rankings[i] = 1;//1등으로 초기화시켜준다. 순위배열을 매 회전마다 1등으로 초기화
            //점수가 높은 것이 있으면 등수를 1씩 늘린다. 2위 3위 4위...
            for (int j = 0; j < scores.Length; j++)
            {
                if (scores[i]<scores[j])//현재i와 나머지j를 비교
                {
                    rankings[i]++;//rank Algorithm i와 j를 비교해서 더 큰점수가 나오면 순위를 1씩 증가(증가하면 순위가 낮아지는거!)

                }
            }
        }

        //[3] Output : 
        for (int i = 0; i < rankings.Length; i++)
        {
            Console.WriteLine($"{scores[i],3}점 : {rankings[i]}등");//score의 i번째 데이터는 몇점이고 ranking 배열의 i는 몇등이다.
        }
    }
}
//[1] Input : 
//[2] Process : Rank
//[3] Output : 
// var rankings = scores.Select(s=>new {Score = s, Rank = scores.Whrer(ss=>ss>s).Count()+1}); //제일 크면 0번째인데 순위상 1번째
