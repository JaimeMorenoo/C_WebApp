using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingInterface
{
    interface IDisplayable
    {
        public string HeaderSymbol {get;}

        void Display();
    }
}
