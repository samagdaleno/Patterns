using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Example
{
    public sealed class MySingletonClass
    {
        private static volatile MySingletonClass _instance;
        private static readonly object _syncLock = new object();

        private MySingletonClass() { Console.WriteLine("The Singleton has been instatiated."); }

        public static MySingletonClass Instance {
            get {
                if (_instance != null) return _instance;

                lock (_syncLock)
                    if (_instance == null) _instance = new MySingletonClass();

                return _instance;
            }
        }

        public void MyPublicMethod(string message) {
            Console.WriteLine("Printing Doc: " + message);
        }

    }
}
