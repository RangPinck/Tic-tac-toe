namespace Exceptoins
{
    /// <summary>
    /// кастомное исключение для выхода пользователя из программы
    /// </summary>
    public class ExitException : Exception
    {
        /// <summary>
        /// конструктор класса кастомного исключения
        /// </summary>
        public ExitException():base(){}
    }
}
