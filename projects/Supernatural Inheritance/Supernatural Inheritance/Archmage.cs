using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_Inheritance
{
    internal class Archmage : Mage
    {
        public Archmage(string Title) : base(Title)
        {

        }

        public override Storm CastRainStorm()
        {
            Storm s = new Storm("RainStorm", true, this.Title);
            return s;
        }

        public Storm CastLightningStorm()
        {
            Storm s = new Storm("Lightning Storm",true, this.Title);
            return s;
        }
    }
}
