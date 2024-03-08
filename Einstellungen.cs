namespace TaschenrechnerLib
{
    public class Einstellungen
    {
        public Modes SetMode(string mode)
        {
            switch (mode)
            {
                case "+":
                    return Modes.Plus;
                case "-":
                    return Modes.Minus;
                case "*":
                    return Modes.Multiply;
                case "/":
                    return Modes.Divide;
                case "%":
                    return Modes.Modulo;
                default:
                    return Modes.None;
            }
        }
        public void SetConsoleToDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
