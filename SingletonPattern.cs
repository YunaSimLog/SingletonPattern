using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonPattern
    {
        public string m_strName { get; private set; }
        public string m_strDesc { get; private set; }

        private static SingletonPattern Inst;

        public static SingletonPattern Instance
        {
            get
            {
                if (Inst == null)
                    Inst = new SingletonPattern();
                return Inst;
            }
        }

        private SingletonPattern()
        {
            m_strName = "";
            m_strDesc = "";
        }

        public void SetData(string strName, string strDesc)
        {
            m_strName = strName;
            m_strDesc = strDesc;
        }

        public void ShowData()
        {
            Console.WriteLine("Name: {0}, Desc: {1}", m_strName, m_strDesc);
        }
    }
}
