﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPractice1
{
    class Sample
    {
        public static int value;
        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
        public Sample()
        {
            Console.WriteLine("(인스턴스) 생성자 호출");                     
        }

        ~Sample()
        {
            Console.WriteLine("소멸자 호출");
        }
    }
    class MyMath
    {
        // Abs(int)
        public static int classVar = 1;
        public int instancVar = 2;
        public static int Abs(int input)
        {
            Console.WriteLine(classVar);
            // 클래스 메서드에서 인스턴스 변수 접근 불가
            //Console.WriteLine(instanceVar);
            return (input >= 0) ? input : -input;
        }

        // Abs(double)
        public static double Abs(double input) { return 0; }
        // Abs(int)
        // 메서드 시그네이처(이름, 매개변수)가 겹쳐서 안됨
        //public static double Abs(int x) { return 0; }
    }

    class FirstClass
    {

    }

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

            // #2 13-6. 삼항 연산자
            Console.WriteLine(number % 2 == 0 ? true : false);

            // #3 14-1. 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray[99]);

            // #3 14-2. while 반복문
            int i = 0;
            int[] intArray2 = { 52, 254, 23 };
            while (i < intArray2.Length)
            {
                Console.WriteLine(intArray2[i]);
                i++;    // 탈출을 위한 변수
            }






            // #5 22-3. 클래스 메서드 <- 여기에서 커밋
            // 위에 클래스 메서드 코드 있음

            // #5 22-3. 클래스 메서드

            // #5 22-4. 메서드 오버로딩
            Console.WriteLine(MyMath.Abs(-10));     // Abs(int)
            Console.WriteLine(MyMath.Abs(10.0));    // Abs(double)
            Console.WriteLine(MyMath.Abs(-10L));    // Abs(double)
            Console.WriteLine(MyMath.Abs(0.3f));    // Abs(double)

            // #5 22-6. 생성자(+ 정적 생성자)
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");

        }
    }
}
