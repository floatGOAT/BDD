#include <iostream>
#include <conio.h>
#include "NumberGuessCPP.cpp"
#define MAX_VALUE 100

using namespace std;

int main()
{
	cout << "Hello!" << endl
		<< "I'm welcome you in the game \"Guess a Number\"!" << endl
		<< "This game is going to guess a number, you imagine, asking your some questions." << endl
		<< "You can answer \"Yes\" or \"No\". Be honest!" << endl
		<< "So, now guess a positive integer in range 0 to "
		<< MAX_VALUE
		<< " and press any key." << endl;
	_getch();
	cout << endl;
	int answer = NumberGuess::StartGuess(MAX_VALUE);
	if (answer >= 0)
	{
		cout << "Your number is " << answer << " !" << endl;
	}
	system("pause");
	return 0;
}