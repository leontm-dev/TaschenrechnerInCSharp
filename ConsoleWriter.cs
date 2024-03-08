namespace TaschenrechnerLib
{
    public class ConsoleWriter
    {
        // Fields

        private Einstellungen Einstellungen = new Einstellungen();

        // Constructors

        public ConsoleWriter() => Einstellungen.SetConsoleToDefault();
        public void SendErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n {message} \n");
            Einstellungen.SetConsoleToDefault();
        }
        public void SendSuccessMessage(string message)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"\n\n  {message}  \n\n");
            Einstellungen.SetConsoleToDefault();
        }
        public void SendMessage(string message)
        {
            Einstellungen.SetConsoleToDefault();
            Console.WriteLine(message);
        }
    }
}
