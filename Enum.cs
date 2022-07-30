using System;

namespace Enum220730
{
    class Enum//enum변수 bakery가 Bakery.Icecream과 같은지 체크하는 예제
    {
        //enum은 열거형 상수(constant)
        //enum문은 클래스 안이나 네임스페이스 안에서만 선언될 수 있다.== 메서드 안이나 속성안에서는 선언X
        public enum Bakery//특징: 숫자형 타입과 호환 가능! enum 타입의 변수를 int로 변경하면 enum값의 숫자값을 얻는다.
        {
            Cake, Icecream, Bread, Candy = 4, Milk = 8
        }//cake는 0번쨰 요소, icecream은 1번쨰, bread는 2번째,candy는 4번째, milk는 8번쨰

        static void Main(string[] args)
        {
            Bakery bakery;
            bakery = Bakery.Icecream;//enum 타입에 값을 대입

            //enum을 int로 변환
            int BakeryValue = (int)bakery;
            if (bakery == Bakery.Icecream)
                Console.WriteLine("Delicios IceCream");
        }
        //flag enum:enum타입이 비트필드를 가진다는것을표시하기위해 enum 선언문 위에 [flag]라는 attribute를 지정
        //attribute=타입/멤버 선언할떄 그 위에 붙이는 특별한 특성값. 해당 타입 혹은 멤버가 어떤 특성을 갖고있는지 표현
        //flag 특성 갖는 flog enum은 or을 이용해 enum변수에 다중값을 가질수있다. 다중값,,
        //                           and를 이용하면 enum 변수가 특정 멤버를 포함하고있는지 체크.
        //flog는 Tostring도 된다.
        //Flag 열거형은 각 비트별로 겹치는 부분이 있으면 안됩니다. 예를 들어, 3(0011), 5(0101) 에서 가장 오른쪽 자리의 1이 겹칩니다. 아래와 같이, Uninque 한 비트캆을 갖도록 하시면 됩니다.
        //
        [Flags]
        enum Border {
        none = 0, top=1, right = 2, bottom = 4, left=8
        }
        static void Sub(string[] args)
        {
            Border b = Border.top | Border.bottom;//다중플래그 할당
            if ((b & Border.top)!=0)//&연산자로 플래그 체크 =>bool형식인거네?
            {
                if (b.HasFlag(Border.bottom))//HasFlog()이용 플래그 체크 =>HasFlog는 뭐길래 bool형식이지?
                    Console.WriteLine(b.ToString());//top,bottom 출력
                {

                }
            }
        }

    }
}
