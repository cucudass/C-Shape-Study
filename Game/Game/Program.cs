using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game {
    class IPhone {
        #region 함수
        // 하나의 특별한 목적의 작업을 수행하기 위해 독립적으로 설계된 코드의 집합
        private int volume;

        public void Modify() {
            Console.WriteLine("조작하다.");
        }

        //함수의 경우 자료형과 반환값의 형태가 일치하지 않으면 error, 함수명을 중복으로 선언 X
        public int GetVolume() {
            return volume;
        }

        //매개변수 - 함수의 정의에서 전달받은 인수를 함수 내부로 전달하기 위해 사용하는 변수
        public void setVolume(int value) {
            //매개변수는 함수 내부에서만 연산이 이루어지며, 함수가 종료되면 메모리에서 사라진다.
            volume = value;
        }
        #endregion
    }

    class Program {
        static void Main(string[] args) {
            #region 인수
            //함수가 호출 될 때 매개 변수에 실제로 전달되는 값
            IPhone se3 = new IPhone();
            se3.Modify();
            se3.setVolume(50);
            Console.WriteLine(se3.GetVolume());
            #endregion
        }
    }
}
