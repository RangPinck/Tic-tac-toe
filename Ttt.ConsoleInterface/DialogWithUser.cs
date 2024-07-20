using Exceptoins;

namespace Ttt.ConsoleInterface
{
    /// <summary>
    /// класс с конструктором, который обрабатывает консольный вариант общения с пользователем
    /// </summary>
    public class DialogWithUser
    {
        /// <summary>
        /// Конструктор класса для общения с пользователем - запуск программы
        /// </summary>
        /// <param name="choiceUser">ссылочный парамет, который принимает в итоге значения выбарнное пользователем</param>
        /// <remarks>
        /// Выбор пользователя:
        /// 1- играть с искуственным интеллектом
        /// 2 - играть с другом рядом
        /// 3 - играть с другом удалённо
        /// 4 - играть с случайным игроком
        /// другое - выход из программы
        /// </remarks>
        public DialogWithUser(ref int choiceUser)
        {
            Console.WriteLine("Hello, you are welcomed by the host of the game tic tac toe!");
            Console.WriteLine("Choose a style of play:");
            Console.WriteLine("1. Play with AI;");

            //Console.WriteLine("2. Play with a friend nearby;");
            //Console.WriteLine("3. Play with a friend remotely;");
            //Console.WriteLine("4. Play with a random player;");
            
            Console.WriteLine("Another. Exit");
            Console.Write("Yuor choice:\t");
            try
            {
                string line = Console.ReadLine();

                choiceUser = int.Parse(
                    !string.IsNullOrEmpty(line) ? line : throw new ExitException()
                    );

                if (choiceUser < 1 || choiceUser > 4)
                {
                    choiceUser = 0;
                    throw new ExitException();
                }
            }
            catch
            {
                Console.WriteLine("You have chosen to exit the program.");
                ProgrammEndMessage();
            }
        }

        /// <summary>
        /// Конструктор клааска для общения с пользователем - закрытие программы
        /// </summary>
        public DialogWithUser()
        {
            Console.WriteLine("Thanks for playing!");
            ProgrammEndMessage();
        }

        /// <summary>
        /// метод для вывода сообщения прощаяния с пользователем
        /// </summary>
        private void ProgrammEndMessage()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
