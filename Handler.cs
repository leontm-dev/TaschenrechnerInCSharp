using System.Text.RegularExpressions;

namespace TaschenrechnerLib
{
    public class Handler
    {
        // Methods

        public bool ValidateUserCalculationInputRaw(string text) => Regex.Match(text.ToString(), "^[0-9]+(\\.[0-9]+)?$").Success;
        public (bool Type, string Message, double Content) ValidateUserCalculationInput (string text)
        {
            if (ValidateUserCalculationInputRaw(text))
            {
                return (true, "Your input is valid", Convert.ToDouble(text));
            } 
            else
            {
                return (true, "Your input is only allowed to contain numbers and max one dot.", double.NaN);
            }
        }
        public bool ValidateUserModeInputRaw(string text) => text == "+" || text == "-" || text == "*" || text == "/" || text == "%";
        public (bool Type, string Message, Modes Content) ValidateUserModeInput(string text)
        {
            if (ValidateUserModeInputRaw(text))
            {
                return (true, "Your input is valid", new Einstellungen().SetMode(text));
            }
            else
            {
                return (false, "The mode can only be + or - or * or / or %", Modes.None);
            }
        }
        public bool ValidateCalculationResultAnswer((double Ergebnis, string Answer) result) => result.Answer == "Success";
        public bool ValidateUserCancelInputRaw(string text) => text == "1" || text == "2";
        public (bool Type, string Message, string Content) ValidateUserCancelInput(string text)
        {
            if (ValidateUserCancelInputRaw(text))
            {
                return (true, "Your input is valid", text);
            } 
            else
            {
                return (false, "The input can only be 1 for goOn and 2 for cancel", "0");
            }
        }
    }
}
