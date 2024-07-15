namespace Ttt.ConsoleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choiceUser = 0;

            DialogWithUser dialogWithUser = new DialogWithUser(ref choiceUser);

            if (choiceUser == 0) return;

            dialogWithUser = new DialogWithUser();
        }
    }
}
