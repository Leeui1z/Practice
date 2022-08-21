//2진 검색은 오름차순으로 정렬이 되어있어야함
//[?] 정렬되어있는 데이터를 이진 검색(이분 탐색)을 사용하여 반씩 나눠서 검색

using System;

/// <summary>
/// 검색 알고리즘(SearchAlgorithm)
/// </summary>
class SearchAlgorithm
{
    static void Main()
    {
        //[1] Input : 
        int[] data = { 1,3,5,7,9};//오름차순으로 정렬되어있다고 가정
        int N = data.Length;//의사 코드
        int search = 3;//검색할 데이터
        bool flag = false;//플래그 변수 : 찾으면 true, 찾지 못하면 false
        int index = -1;//인덱스 변수: 찾은 위치. -1로 초기화.flag가 true면 index는 0이상이 된다.

        //[2] Process : 이진 검색(Binary Search):Full Scan -> Index Scan
        int low = 0;//낮은 인덱스 min
        int high = N - 1;//높은 인덱스 max
        while (low<=high)//low가 high보다 작거나 같을때까지 반복
        {//반복할떄마다 중간값을 구한다.
            int mid = (low + high) / 2;//중간 인덱스 구하기
            if (data[mid]==search)
            {
                flag = true; index = mid; break;
            }
            if (data[mid]>search)
            {
                high = mid - 1;//찾을 데이터가 중간값보다 작으면 왼쪽으로 이동
            }
            else
            {
                low = mid - 1;//찾을 데이터가 크면 오른쪽 영역으로 이동
            }
        }

        //[3] Output : 
        if (flag)
        {
            Console.WriteLine($"{search}을(를) {index}위치에서 찾았습니다.");
        }
        else
        {
            Console.WriteLine("찾지 못했습니다.");

        }

    }
}

//[1] Input : 
//[2] Process : 
//[3] Output : 

//int[] data = { 1, 3, 5, 7, 9 };
//var result = data.ToList().BinarySearch(9);
result => 4