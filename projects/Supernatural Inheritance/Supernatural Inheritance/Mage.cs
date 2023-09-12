using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_Inheritance
{
    internal class Mage : Pupil
    {
        public Mage(string Title) : base(Title)
        {
           
         }

        public virtual Storm CastRainStorm()
        {
            Storm s = new Storm("weak rain storm", false, this.Title);
            return s;
        }

    }
}
