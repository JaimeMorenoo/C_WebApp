using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingInterface
{
    internal class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public string HeaderSymbol => "------";

        public void Display()
        {
            if(Hidden == false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine("****");
            }

        }

        public void Reset()
        {
            this.Password = "";
            this.Hidden = false;
        }
    }
}
