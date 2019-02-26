using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingletonClass PrintSpooler = MySingletonClass.Instance;
            MySingletonClass PrintSpooler2 = MySingletonClass.Instance;


            Parallel.Invoke(() => PrintSpooler.MyPublicMethod("DOC1.doc"), () => PrintSpooler2.MyPublicMethod("DOC2.doc"));
            Console.ReadKey();
        }
    }
}
