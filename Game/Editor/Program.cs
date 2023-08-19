using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor {
    class Program {
        static void Main(string[] args) {
            #region 반복문
            //프로그램 내에서 특정한 작업을 반복적으로 수행하는 명령문
            //증감 연산자 -> 피연산자를 하나씩 증가시키거나 감소시킬 때 사용
            //전위 증감 연산자 -> 변수의 값을 증감시킨 후 연산 수행
            /**
            int data =  0;
            data = ++data;
            Console.WriteLine("1: " + data);
            data = --data;
            Console.WriteLine("2: " + data);
            **/

            //후위 증감 연산자 -> 연산을 수행한 다음 변수의 값을 증감
            int health = 0;
            int damage = 1;

            health = damage--;
            Console.WriteLine("health 1: "+ health);
            health = damage++;
            Console.WriteLine("health 2: " + health);
            #endregion
        }
    }
}
