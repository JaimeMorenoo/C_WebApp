using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingInterface
{
    internal class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {            
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            
        }

        public string HeaderSymbol => "-----";

        public void Display()
        {
            Console.WriteLine(HeaderSymbol);
            foreach(string todo in Todos)
            {
                Console.WriteLine(todo);
            }
                
        }

        public void Reset()
        {
            this.Todos = Array.Empty<string>();
            this.Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}
