using System;


class AverageAlgorithm
{
    static void Main()
    {
        //[1] 입력 : n명의 성적
        int[] data = { 90, 65, 78, 50, 95 };
        int sum = 0;
        int count = 0;

        //[2] 처리 : AVG = SUM / COUNT
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= 80 && data[i]<=95)
            {
                sum += data[i]; //sum
                count++; //count
            }
        }
        double avg = sum / (double)count;
        // [3] 출력
        Console.WriteLine($"80점 이상 95점 이하인 자료의 평균 : {avg}");
    }
}
