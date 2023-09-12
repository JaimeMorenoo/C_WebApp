namespace SavingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Add("Party");
   
 



            PasswordManager pm = new PasswordManager("iluvpie", true);
            tdl.Display();

            tdl.Reset();
            pm.Reset();

            
            pm.Display();
        }
    }
}