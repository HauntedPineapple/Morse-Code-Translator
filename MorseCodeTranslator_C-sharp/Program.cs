using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator_C_sharp
{
    class Program
    {
        // NOTES:
        // this translator uses INTERNATIONAL morse code
        // a PERIOD "." will be used to represent DOTS
        // a HYPHEN "-" will be used to represent DASHES
        // LETTERS are separated by SPACES
        // WORDS are separated by FORWARD SLASHES "/"

        static Dictionary<char, string> morseDictionary;

        static void Main(string[] args)
        {
            morseDictionary = new Dictionary<char, string>()
            {
                { 'a',".-"}, { 'b',"-..."}, { 'c',"-.-."}, { 'd',"-.."},
                { 'e',"."}, { 'f',"..-."}, { 'g',"--."}, { 'h',"...."},
                { 'i',".."}, { 'j',".---"}, { 'k',"-.-"}, { 'l',".-.."},
                { 'm',"--"}, { 'n',"-."}, { 'o',"---"}, { 'p',".--."},
                { 'q',"--.-"}, { 'r',".-."}, { 's',"..."}, { 't',"-"},
                { 'u',"..-"}, { 'v',"...-"}, { 'w',".--"}, { 'x',"-..-"},
                { 'y',"-.--"}, { 'z',"--.."},
                { '0',"-----"}, { '1',".----"},  { '2',"..---"},
                { '3',"...--"}, { '4',"....-"}, { '5',"....."}, { '6',"-...."},
                { '7',"--..."}, { '8',"---.."}, { '9',"----."},
                { '.',".-.-.-"},
                { ',',"--..--"}, { '?',"..--.."}, { '!',"-.-.--"}, { '\'',".----."},
                { '"',".-..-."}, { '(',"-.--.-"}, { ')',"-.--."}, { '&',".-..."},
                { ':',"---..."}, { ';',"-.-.-."}, { '/',"-..-."}, { '_',"..--.-"},
                { '=',"-...-"}, { '+',".-.-."}, { '-',"-....-"}, { '@',".--.-."}
            };

            TestCode();

            Console.ReadLine();
        }

        static string MorseToEnglish(string message)
        {
            string output = "";
            string[] messageWords = message.Split(new string[] { " / " }, StringSplitOptions.RemoveEmptyEntries); ;
            //string[] wordLetters = messageWords.Split(' ');
            // List represents sentence with each array representing a word in the message
            List<string[]> wordLetters = new List<string[]>();
            foreach (string word in messageWords)
            {
                wordLetters.Add(word.Split(' '));
            }

            int count = 0;
            for (int a = 0; a < wordLetters.Count; a++)
            {
                count++;
                for (int i = 0; i < wordLetters[a].Length; i++)
                {
                    foreach (KeyValuePair<char, string> entry in morseDictionary)
                    {
                        if (wordLetters[a][i] == entry.Value)
                        {
                            output += entry.Key;
                            break;
                        }
                    }
                }
                if (count < wordLetters.Count)
                {
                    output += " ";
                }
            }

            return output.ToUpper();
        }

        static string EnglishToMorse(string message)
        {
            string output = "";
            message = message.ToLower();
            string[] messageWords = message.Split(' ');

            int wordCount = 0;
            int letterCount = 0;
            for (int i = 0; i < messageWords.Length; i++)
            {
                wordCount++;
                foreach (char letter in messageWords[i])
                {
                    letterCount++;
                    foreach (KeyValuePair<char, string> entry in morseDictionary)
                    {
                        if (letter == entry.Key)
                        {
                            output += entry.Value;
                            break;
                        }
                    }
                    if (letterCount < messageWords[i].Length)
                    {
                        output += " ";
                    }
                }
                letterCount = 0;
                if (wordCount < messageWords.Length)
                {
                    output += " / ";
                }
            }

            return output;
        }

        static void TestCode()
        {
            string[] morseInput = new string[] { ".... . .-.. .-.. --- / .-- --- .-. .-.. -..",
                                                 ".-- .... .- - .----. ... / ..- .--.",
                                                 "..--- / .-.-. / ..--- / -...- / ....-",
            ".. ... -. .----. - / - .... .. ... / -.-. --- --- .-.. ..--.."};
            foreach (string input in morseInput)
            {
                Console.WriteLine("\"" + input + "\" --> \"" + MorseToEnglish(input) + "\"");
                Console.WriteLine();
            }

            string[] englishInput = new string[] { "I love code!",
                                                   "3 x 2 = 6",
                                                   "This *** is not valid",
                                                   "Blackbird singing in the dead of night",
                                                   "Take these broken wings and learn to fly"};
            foreach (string input in englishInput)
            {
                Console.WriteLine("\"" + input + "\" --> \"" + EnglishToMorse(input) + "\"");
                Console.WriteLine();
            }
        }
    }
}
