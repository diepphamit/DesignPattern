using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class SingletonClass
    {
        private static SingletonClass instance;
        private static readonly object instanceLock = new object();
        private SingletonClass() { }

        public static SingletonClass GetInstance()
        {
            if(instance == null)
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new SingletonClass();
                    }
                }
            }
            return instance;        
        }
    }
}
