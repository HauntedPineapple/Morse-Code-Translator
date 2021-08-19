# this translator uses INTERNATIONAL morse code
# a PERIOD "." will be used to represent DOTS
# a HYPHEN "-" will be used to represent DASHES
# LETTERS are separated by SPACES
# WORDS are separated by FORWARD SLASHES "/"

MORSE = {"a": ".-", "b": "-...", "c": "-.-.", "d": "-..",
         "e": ".", "f": "..-.", "g": "--.", "h": "....",
         "i": "..", "j": ".---", "k": "-.-", "l": ".-..",
         "m": "--", "n": "-.", "o": "---", "p": ".--.",
         "q": "--.-", "r": ".-.", "s": "...", "t": "-",
         "u": "..-", "v": "...-", "w": ".--", "x": "-..-",
         "y": "-.--", "z": "--..",
         "0": "-----", "1": ".----", "2": "..---", "3": "...--",
         "4": "....-", "5": ".....", "6": "-....",
         "7": "--...", "8": "---..", "9": "----.",
         ".": ".-.-.-", ",": "--..--", "?": "..--..", "!": "-.-.--",
         "'": ".----.", "\"": ".-..-.", "(": "-.--.-", ")": "-.--.",
         "&": ".-...", ":": "---...", ";": "-.-.-.", "/": "-..-.",
         "_": "..--.-", "=": "-...-", "+": ".-.-.",
         "-": "-....-", "@": ".--.-."}


def english_to_morse(message):
    pass


def morse_to_english(message):
    pass


morseInput = (".... . .-.. .-.. --- / .-- --- .-. .-.. -..",
              ".-- .... .- - .----. ... / ..- .--.",
              "..--- / .-.-. / ..--- / -...- / ....-",
              ".. ... -. .----. - / - .... .. ... / -.-. --- --- .-.. ..--..")
englishInput = ("I love code!",
                "3 x 2 = 6",
                "This *** is not valid",
                "Blackbird singing in the dead of night",
                "Take these broken wings and learn to fly")

for i in morseInput:
    print("\"" + i + "\" --> \"" + morse_to_english(i) + "\"")
    
for i in englishInput:
    print("\"" + i + "\" --> \"" + english_to_morse(i) + "\"")
