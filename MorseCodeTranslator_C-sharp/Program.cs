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
        // if a letter cannot be translated, it will be output as "#"

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
        }

        static string morseToEnglish(string message)
        {
            return null;
        }

        static string englishToMorse(string message)
        {
            return null;
        }
    }
}
