using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Engines
{
    public class SportEngine : Engine
    {
        public SportEngine() {
            name = "S75r7ds PW";
            maxSpeed = "320 Km/h";
            type = "Electric Automatic";
            HP = "789";
        }
    }
}
