using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public interface IAdapter
    {
        string Location();
        string Date();
        string Time();
        double Temperature();
        string Unit();
    }
}
