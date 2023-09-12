using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_Inheritance
{
    internal class Pupil
    {
        public string Title { get; private set; }

        public Pupil(string title)
        {
            this.Title = title;
        }

        public Storm CastWindStorm()
        {
            Storm s = new Storm("wind", false, this.Title);

            return s;
        }
    }
}
