using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Program
    {
        static SingletonPattern m_SingletonPattern;

        static void Main(string[] args)
        {
            // 싱글톤 패턴 초기화
            m_SingletonPattern = SingletonPattern.Instance;

            // 싱글톤 패턴에 데이터 1차 삽입
            m_SingletonPattern.SetData("Main 데이터", "1차");
            m_SingletonPattern.ShowData();

            new TempClass();
            m_SingletonPattern.ShowData();

            new TempClass2();
            m_SingletonPattern.ShowData();
        }
    }

    public class TempClass
    {
        SingletonPattern m_SingletonPattern;

        public TempClass()
        {
            m_SingletonPattern = SingletonPattern.Instance;

            // 싱글톤 패턴에 데이터 2차 삽입
            m_SingletonPattern.SetData("TempClass 데이터", "2차");

        }
    }

    public class TempClass2
    {
        SingletonPattern m_SingletonPattern;

        public TempClass2()
        {
            m_SingletonPattern = SingletonPattern.Instance;

            // 싱글톤 패턴에 데이터 3차 삽입
            m_SingletonPattern.SetData("TempClass2 데이터", "3차");

        }
    }

}
