using System; 
using System.IO;
using System.Text.RegularExpressions;

namespace RegularExpression {
    class Program {
        static void Main(string[] args) {
                        string text = System.IO.File.ReadAllText(@"./input2.txt");
                        string pattern = @"\d{2,3}";
                        Regex regex = new Regex(pattern);
                         MatchCollection matches = regex.Matches(text);
                         foreach (Match match in matches) {
                             int parsedNumber;
                    if (int.TryParse(match.Value, out parsedNumber)) {
                       char convertedChar = Convert.ToChar(parsedNumber);
                       Console.WriteLine(convertedChar);
                }
                         }
        }
    }
}
