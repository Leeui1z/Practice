//[?] 주어진 데이터에서 가장 많이 나타난(중복된)값

using System;
using System.Linq;

/// <summary>
/// 최빈값 알고리즘(ModeAlgorithm) : 점수 index(0~n)의 개수(count)의 최댓값(Max)
/// </summary>

class ModeAlgorithm
{
    static void Main()
    {
        //[1] Input : 
        int[] scores = { 1, 3, 4, 3, 5 };//0~5까지만 들어온다고 가정
        int[] indexs = new int[5 + 1];//정수형배열 0~5까지 점수index의 "개수"를 저장=>개수 알고리즘
        //최빈값 알고리즘=점수를 index로 보고 인덱스의 count를 구하고 count의 max, 최댓값 알고리즘
        //범위가 굉장히 넓은 경우엔 hashtable같은 자료구조 structure사용을 권장.
        int max = int.MinValue;//최댓값알고리즘에서는 max변수에서는 정수형이 가질 수 있는 minValue로 "초기화"!!!
        int mode = 0;//최빈값이 담길 그릇, 현재는 0.

        //[2] Process : Data -> Index -> Count -> Max -> Mode
        for (int i = 0; i < scores.Length; i++)
        {
            indexs[scores[i]]++;//데이터를 인덱스로 보고 그것을 카운트.
            //score의 i번째, 1점을 index배열의 1번째 index로 본다.
            //Data -> Index -> Count 파트
        }
        //최댓값 알고리즘 적용
        for (int j = 0; j < indexs.Length; j++)
        {
            if (indexs[j]>max)//인덱스의 j번쨰 값이 max값보다 크다면
            {
                max = indexs[j]; //max알고리즘
                mode = j;//max알고리즘일때 index를 mode라고 부른다.
                //모드알고리즘~
            }
        }


        //[3] Output : 
        Console.WriteLine($"최빈값(문):{mode}-{max}번 나타남");

        var q = scores.GroupBy(v=>v).OrderByDescending(g=>g.Count()).First();//scores의 linq에서 제공해주는 확장메소드중 데이터들을 그룹화시켜주는 GroupBy.
                                                                             //Value를 Value값으로, 1차원배열을 그룹화한다.(1|3,3|4|5)
                                                                             //OrderByDescending 가장 많이나온 것에 따라 역순으로Group=>Group.count(3,3|1|4|5)
                                                                             //First : 인자가 여러개일 수 있으니까 first one default로 읽어온다? query문
        int modeCount = q.Count(); //가장 많이 나온것이 몇번나왔는지(3이 "2"번)
        int frequency = q.Key;//가장 많이 나온 것의 그룹 이름?(3)
        Console.WriteLine($"최빈값(식):{frequency}-{modeCount}번 나타남");
    }
}
