using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game {
    class Variable {
        //프로그램이 실행되는 진입점
        static void Main(string[] args) {
            //Console.WriteLine(): 특정 문자열을 출력하는 함수
            Console.WriteLine("Hello, World");

            #region 변수
            // 데이터를 저장할 수 있는 메모리 공간을 생성하는 것
            // 자료형 -> 데이터를 저장하기 위해 데이터를 정해주는 것

            // //etc...
            // //bool <- 1 byte
            // bool data = false;
            // Console.WriteLine("data: "+data);
            // //문자
            // //char <- 1 byte
            // char alphabet = 'A';
            // Console.WriteLine("alphabet: " + alphabet);
            // //정수
            // //short <- 2 byte
            // //int <- 4 byte
            // int attack = 10;
            // Console.WriteLine("attack: " + attack);
            // //실수
            // //float <- 4 byte
            // //double <- 8 byte
            // float exp = 99.75f;
            // Console.WriteLine("exp: " + exp);
            // //문자열
            // //string <- 16 byte
            // string name = "Goblin";
            // Console.WriteLine("name: " + name);
            #endregion

            #region 변수이름 규칙
            // 1. 변수의 이름은 숫자로 시작 X
            // ex) int i5 = 10;

            // 2. 변수의 이름에는 공백 X
            // ex) int level up = 30;

            // 3. 변수 이름 중복 X
            // 변수의 이름은 대소문자 구분 O
            // ex) int value = 10;
            // ex) int VALUE = 20;

            // 4. 변수의 이름으로 예약어 사용 X
            // 5. 변수 이름의 특수 기호는 "_" 만 사용 가능
            #endregion

            #region 상수
            // 프로그램이 실행되는 동안 더 이상 변경할 수 없는 메모리 공간
            // ex) 몬스터 이름, npc 이름 등등...
            // int count = 0;
            // count = 100;

            //상수는 메모리 공간 생성하는 동시에 초기화해야 한다. 한번 저장되면 더 이상 변경 불가
            // const float pi = 3.141592f;

            //상수
            // 리터럴 상수 -> 메모리 공간을 가지지 않는 상수
            // 심볼릭 상수 -> 메모리 공간을 가지는 상수
            #endregion

        }
    }
}
