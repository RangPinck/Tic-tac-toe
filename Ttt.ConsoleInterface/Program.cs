namespace Ttt.ConsoleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region User's_choice

            int choiceUser = 0;

            DialogWithUser dialogWithUser = new DialogWithUser(ref choiceUser);

            if (choiceUser == 0) return;

            dialogWithUser = new DialogWithUser();

            #endregion
        }
    }
}
