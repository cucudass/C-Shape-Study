using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game {
    #region class
    //사용자 정의 데이터 유형으로 속성, 함수가 포함되어 있으며, 클래스를 통해 객채를 생성하여 접근하고 사용할 수 있는 집합체
    public class Monster {
        //접근지정자 -> 클래스 내부에 포함되어 있는 속정의 접근 범위를 제한하는 지정자
        //public: 클래스 내부와 외부 및 자기가 상속하는 클래스에서 접근을 허용
        //private: 클래스 내부에서만 접근 가능. 외부 및 자기가 상속하는 클래스에서 접근 허용 X
        //protected: 클래스 내부와 자기가 상속하는 클래스에서만 접근을 허용. 외부에서는 접근 허용 X
        //기본접근지정자: private

        public int health;
        public char grade;

        //바이트 패딩 -> 멤버 변수를 메모리에서 cpu로 읽을 때 한 번에 읽을 수 있도록, 레지스터 블록에 맞춰서 바이트를 패딩해주는 최적화 작업
    }
    
    #endregion
    class Program {
        static void Main(string[] args) {
            #region 배열
            ////같은 자료형의 변수들로 이루어진 유한 집합
            ////원하는 원소에 원하는 값을 저장하며, 컴파일 되는 시점부터 고정된 메모리 공간을 가진다.
            //int[] array = new int[3];
            //array[0] = 10;
            //array[1] = 20;
            //array[2] = 30;

            //for (int i = 0; i < array.Length; i++) {
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #region 박싱과 언박싱
            //박싱: 값 형식을 참조하는 형식으로 변환하는 작업
            //int x = 100;
            //
            //object obj = x;
            //
            ////언박싱: 참조 형식을 값 형식으로 변환하는 작업
            //int result = (int)obj;
            #endregion

            #region 클래스 선언
            Monster monster = new Monster();
            monster.health = 100;
            #endregion

        }
    }
}
