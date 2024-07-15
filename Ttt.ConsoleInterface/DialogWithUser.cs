using Exceptoins;

namespace Ttt.ConsoleInterface
{
    public class DialogWithUser
    {
        public DialogWithUser(ref int chouseUser)
        {
            Console.WriteLine("Hello, you are welcomed by the host of the game tic tac toe!");
            Console.WriteLine("Choose a style of play:");
            Console.WriteLine("1. Play with AI;");
            //Console.WriteLine("2. Play with a friend nearby;");
            //Console.WriteLine("3. Play with a friend remotely;");
            //Console.WriteLine("4. Play with a random player;");
            Console.WriteLine("Another. Exit");
            Console.WriteLine("Yuor choice:\t");
            try
            {
                string line = Console.ReadLine();
                chouseUser = int.Parse(
                    !string.IsNullOrEmpty(line) ? line : throw new ExitException()
                    );
            }
            catch
            {

            }
        }


    }
}
