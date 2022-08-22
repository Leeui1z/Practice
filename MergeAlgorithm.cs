using System;
//Merge Algorithm 병합, 정렬 알고리즘

//[?]두개의 정수배열 합치기. 단, 2개의 배열은 오름차순으로 정렬되어있다고 가정
///병합알고리즘:오름차순으로 정렬되어있는 정수배열을 하나로 병합
class MergeAlgorithm
{
    static void Main()
    {
        //[1]
        int[] first = { 1, 3, 5 };
        int[] second = { 2, 4 };
        int M = first.Length; int N = second.Length;//M:N관행
                                                    //첫번째 배열의 크기를 M, 두번째 배열의 크기를 N
                                                    //첫번째 배열 index는 i,두번째는 j,세번쨰는 k…
        int[] merge = new int[M + N];//병합된 배열 담을 그릇
        //first와 second가 들어갈 내용이니 M+N크기의 배열. 5개Length를 가짐
        int i = 0; int j = 0; int k = 0;//ijk 관행
                                //i는 first, j는 second, k는 merge배열의 index

        //[2]: merge
        while(i < M && j < N)
         {
            if(first[i] <= second[j])
             {
                merge[k];
             }
        }
        //[3]
        foreach(var m in merge)
        {
            Console.WriteLine($"{ m}\t");
           
        }

    }
   

    }
}
