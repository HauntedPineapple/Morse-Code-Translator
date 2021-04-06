#include <iostream>
#include <string>
#include <map>
#include <iterator>

using namespace std;

// NOTES:
// this translator uses INTERNATIONAL morse code
// a PERIOD "." will be used to represent DOTS
// a HYPHEN "-" will be used to represent DASHES
// LETTERS are separated by SPACES
// WORDS are separated by FORWARD SLASHES "/"
// if a letter cannot be translated, it will be output as "#"

int main() {
	map<char, string>* morseDictionary = new map<char, string>();
#pragma region Map creation
	morseDictionary->insert(make_pair('a', ".-"));
	morseDictionary->insert(make_pair('b', "-..."));
	morseDictionary->insert(make_pair('c', "-.-."));
	morseDictionary->insert(make_pair('d', "-.."));
	morseDictionary->insert(make_pair('e', "."));
	morseDictionary->insert(make_pair('f', "..-."));
	morseDictionary->insert(make_pair('g', "--."));
	morseDictionary->insert(make_pair('h', "...."));
	morseDictionary->insert(make_pair('i', ".."));
	morseDictionary->insert(make_pair('j', ".---"));
	morseDictionary->insert(make_pair('k', "-.-"));
	morseDictionary->insert(make_pair('l', ".-.."));
	morseDictionary->insert(make_pair('m', "--"));
	morseDictionary->insert(make_pair('n', "-."));
	morseDictionary->insert(make_pair('o', "---"));
	morseDictionary->insert(make_pair('p', ".--."));
	morseDictionary->insert(make_pair('q', "--.-"));
	morseDictionary->insert(make_pair('r', ".-."));
	morseDictionary->insert(make_pair('s', "..."));
	morseDictionary->insert(make_pair('t', "-"));
	morseDictionary->insert(make_pair('u', "..-"));
	morseDictionary->insert(make_pair('v', "...-"));
	morseDictionary->insert(make_pair('w', ".--"));
	morseDictionary->insert(make_pair('x', "-..-"));
	morseDictionary->insert(make_pair('y', "-.--"));
	morseDictionary->insert(make_pair('z', "--.."));
	morseDictionary->insert(make_pair('0', "-----"));
	morseDictionary->insert(make_pair('1', ".----"));
	morseDictionary->insert(make_pair('2', "..---"));
	morseDictionary->insert(make_pair('3', "...--"));
	morseDictionary->insert(make_pair('4', "....-"));
	morseDictionary->insert(make_pair('5', "....."));
	morseDictionary->insert(make_pair('6', "-...."));
	morseDictionary->insert(make_pair('7', "--..."));
	morseDictionary->insert(make_pair('8', "---.."));
	morseDictionary->insert(make_pair('9', "----."));
	morseDictionary->insert(make_pair('.', ".-.-.-"));
	morseDictionary->insert(make_pair(',', "--..--"));
	morseDictionary->insert(make_pair('?', "..--.."));
	morseDictionary->insert(make_pair('!', "-.-.--"));
	morseDictionary->insert(make_pair('\'', ".----."));
	morseDictionary->insert(make_pair('"', ".-..-."));
	morseDictionary->insert(make_pair('(', "-.--.-"));
	morseDictionary->insert(make_pair(')', "-.--."));
	morseDictionary->insert(make_pair('&', ".-..."));
	morseDictionary->insert(make_pair(':', "---..."));
	morseDictionary->insert(make_pair(';', "-.-.-."));
	morseDictionary->insert(make_pair('/', "-..-."));
	morseDictionary->insert(make_pair('_', "..--.-"));
	morseDictionary->insert(make_pair('=', "-...-"));
	morseDictionary->insert(make_pair('+', ".-.-."));
	morseDictionary->insert(make_pair('-', "-....-"));
	morseDictionary->insert(make_pair('@', ".--.-."));
#pragma endregion

	delete morseDictionary;
	morseDictionary = nullptr;
}