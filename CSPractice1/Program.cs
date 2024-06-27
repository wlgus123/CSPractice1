using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPractice1
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // #1 12-1. 기본 용어
            // int base = 0;
            var abc = 3;
            // var var = 3;

            // 한줄 주석
            /*
             * 여러 줄 주석
             */

            // #1 12-2. 출력
            Console.WriteLine("Hello World");
            Console.Write("줄바꿈 안하기");

            // #1 12-3. 기본 자료형
            // 정수
            Console.WriteLine(52 + 4 - 1);
            // 사칙연산자 = 산술 연산 = Arithmetic Operator
            // + - * / %

            // 실수(Real Number)
            Console.WriteLine(52.0);

            // 문자(Character)
            Console.WriteLine('A');
            Console.WriteLine('가');

            // 문자열(String)
            Console.WriteLine("Hello World");
            //Escape Character(탈출 문자)
            Console.WriteLine("d\n\t림\t마\"고");

            // 문자열 연결 연산자(Concatenation Operator)
            Console.WriteLine("Hello" + " " + "World");

            // 문자열 인덱스 접근 [ ]
            Console.WriteLine("Hello World"[4]);    // 'o' 출력
            //Console.WriteLine("Hello World"[100]);  // 예외 발생
            //Console.WriteLine("Hello World"[-3]);   // 예외 발생

            // 주의
            Console.WriteLine('가' + '힣');
            // 문자열 연결 연산자X, 덧셈 연산자

            // 논리 (Boolean)
            Console.WriteLine(true);
            Console.WriteLine(false);

            // 비교 연산자
            // == != > < >= <=

            // 논리 연산자
            // && || !  and or not
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);

            // #1 12-4. 변수
            string s = "문자열 자료형";

            // #1 12-5. 복합대입연산자
            // += -= *= /= %=
            string output = "Hello";
            output += " World";
            Console.WriteLine(output);

            // #1 12-6. 증감 연산자
            int number = 10;
            Console.WriteLine(number++);    // 10
            Console.WriteLine(++number);    // 12
            Console.WriteLine(number--);    // 12
            Console.WriteLine(--number);    // 10

            // #1 12-8. var 키워드
            var varnumber = 20;
            //var abc;    // 반드시 초기화 해줘야 함

            // #1 12-9. 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // #1 12-10. 자료형변환
            // 굉장히 중요

            // #2 13-1. if 조건문
            bool condition = true;
            if (condition)
            {
                // some
            }
            else if (condition) {
                // some1
            }
            else
            {
                // other
            }

            // #2 13-2. swtich 조건문
            // 상태가 정해졌을 때 많이 사용
            int v = 0;
            switch (v)
            {
                case 0:
                    break;
                default:
                    break;
            }

            // #2 13-3. 삼항 연산자
            Console.WriteLine(number % 2 == 0 ? true : false);
        }
    }
}
