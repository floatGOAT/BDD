#include <iostream>
#include <string>

using namespace std;

class NumberGuess
{
public:
	static int StartGuess(int upperBoard)
	{
		int middle;
		string answer;
		int low = 0;
		int high = upperBoard;
		while (low < high)
		{
			middle = (low + high) / 2;
			cout << "Is your number bigger than " << middle << " ? (Y\\N)" << endl;
			cin >> answer;
			switch (answer[0])
			{
			case 'Y':
			case 'y':
				if (middle >= low)
					low = middle + 1;
				break;
			case 'N':
			case 'n':
				if (middle <= high)
					high = middle;
				break;
			default:
				cout << "Unexpected answer! Try to answer \"Yes\" or \"No\"." << endl;
				break;
			}
		}
		if (low == upperBoard)
		{
			Label1:
			cout << "Is your number bigger than " << upperBoard << " ? (Y\\N)" << endl;
			cin >> answer;
			switch (answer[0])
			{
			case 'Y':
			case 'y':
				cout << "You have a mistake! You are meant to guess a number between 0 and " << upperBoard << "!" << endl;
				return -1;
			case 'N':
			case 'n':
				return low;
			default:
				cout << "Unexpected answer! Try to answer \"Yes\" or \"No\"." << endl;
				goto Label1;
			}
		}
		if (low == 0)
		{
			Label2:
			cout << "Is your number lower than " << 0 << " ? (Y\\N)" << endl;
			cin >> answer;
			switch (answer[0])
			{
			case 'Y':
			case 'y':
				cout << "You have a mistake! You are meant to guess a number between 0 and " << upperBoard << "!" << endl;
				return -1;
			case 'N':
			case 'n':
				return low;
			default:
				cout << "Unexpected answer! Try to answer \"Yes\" or \"No\"." << endl;
				goto Label2;
			}
		}
	return low;
	}
};