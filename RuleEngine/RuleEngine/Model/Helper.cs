
namespace RuleEngine.Model
{
    class Helper
    {
        public static int ParseStringToInt(string text)
        {
            int pos = 15;
            int.TryParse(text, out pos);
            return pos;
        }
    }
}
