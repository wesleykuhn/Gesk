using System.Linq;

namespace Gesk.Library.Checker
{
    public static class Validator
    {
        public static char[] Numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static bool TextBoxesHasWord(System.Windows.Forms.TextBox[] textBoxes)
        {
            foreach (System.Windows.Forms.TextBox textBox in textBoxes)
            {
                if (StringHasWord(textBox.Text)) return true;
            }
            return false;
        }

        public static bool StringHasNumber(string text)
        {
            foreach (char character in text)
            {
                foreach (char number in Validator.Numbers)
                {
                    if (character == number) return true;
                }
            }

            return false;
        }

        public static bool StringHasWord(string text)
        {
            foreach (char character in text)
            {
                if (!Validator.Numbers.Contains(character)) return true;
            }

            return false;
        }
    }
}
